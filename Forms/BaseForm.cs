using MaterialSkin;
using MaterialSkin.Controls;
using KompanzasyonHesapSistemi.Services;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Forms
{
    /// <summary>
    /// Rugged & Simplified BaseForm.
    /// High-contrast for field use, but visual borders removed per user request.
    /// </summary>
    public class BaseForm : MaterialForm
    {
        protected readonly MaterialSkinManager MaterialSkinManager;

        public BaseForm()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.KeyPreview = true; // Enter to Tab logic remains
            MaterialSkinManager = MaterialSkinManager.Instance;
            MaterialSkinManager.AddFormToManage(this);

            NotificationService.OnNotify += HandleNotification;
            this.FormClosed += (s, e) => 
            {
                NotificationService.OnNotify -= HandleNotification;
                MaterialSkinManager.RemoveFormToManage(this);
            };
            this.KeyDown += BaseForm_KeyDown;
        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                if (this.ActiveControl is TextBox txt && txt.Multiline) return;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        protected async Task RunSafeTaskAsync(Func<Task> task)
        {
            try
            {
                this.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                await task();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
            }
            finally
            {
                this.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void HandleNotification(string message, int duration)
        {
            if (Form.ActiveForm == this)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => ShowSnackBar(message, duration)));
                }
                else
                {
                    ShowSnackBar(message, duration);
                }
            }
        }

        public void ShowSnackBar(string message, int duration = 3000)
        {
            var snackBar = new MaterialSnackBar(message, duration);
            snackBar.Show(this);
        }

        protected void NotifySuccess(string message) => NotificationService.ShowSuccess(message);
        protected void NotifyWarning(string message) => NotificationService.ShowWarning(message);
        protected void NotifyError(string message) => NotificationService.ShowError(message);
        protected void NotifyInfo(string message) => NotificationService.ShowInfo(message);
    }
}
