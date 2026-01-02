using System;

namespace KompanzasyonHesapSistemi.Services
{
    /// <summary>
    /// Bildirim türleri
    /// </summary>
    public enum NotificationType
    {
        Success,
        Warning,
        Error,
        Info
    }

    /// <summary>
    /// Merkezi bildirim yönetim servisi.
    /// Avant-Garde UI felsefesine uygun, non-blocking bildirimler sağlar.
    /// </summary>
    public static class NotificationService
    {
        // Emoji prefixleri - minimalist ve anlaşılır
        private const string SuccessPrefix = "✓";
        private const string WarningPrefix = "⚠";
        private const string ErrorPrefix = "✕";
        private const string InfoPrefix = "ℹ";

        // Varsayılan süreler (ms)
        private const int SuccessDuration = 3000;
        private const int WarningDuration = 4000;
        private const int ErrorDuration = 5000;
        private const int InfoDuration = 3000;

        /// <summary>
        /// Bildirim göstermek için event. BaseForm bu event'e subscribe olur.
        /// </summary>
        public static event Action<string, int>? OnNotify;

        /// <summary>
        /// Başarılı işlem bildirimi
        /// </summary>
        public static void ShowSuccess(string message, int? duration = null)
        {
            Notify($"{SuccessPrefix} {message}", duration ?? SuccessDuration);
        }

        /// <summary>
        /// Uyarı bildirimi
        /// </summary>
        public static void ShowWarning(string message, int? duration = null)
        {
            Notify($"{WarningPrefix} {message}", duration ?? WarningDuration);
        }

        /// <summary>
        /// Hata bildirimi
        /// </summary>
        public static void ShowError(string message, int? duration = null)
        {
            Notify($"{ErrorPrefix} {message}", duration ?? ErrorDuration);
        }

        /// <summary>
        /// Bilgi bildirimi
        /// </summary>
        public static void ShowInfo(string message, int? duration = null)
        {
            Notify($"{InfoPrefix} {message}", duration ?? InfoDuration);
        }

        /// <summary>
        /// Ham bildirim gönderimi (prefix olmadan)
        /// </summary>
        public static void Show(string message, int duration = 3000)
        {
            Notify(message, duration);
        }

        private static void Notify(string message, int duration)
        {
            OnNotify?.Invoke(message, duration);
        }
    }
}
