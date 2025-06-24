using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrayPassGen
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TrayContext());
        }
    }

    internal sealed class TrayContext : ApplicationContext
    {
        private readonly NotifyIcon _trayIcon;

        public TrayContext()
        {
            var menu = new ContextMenuStrip();
            menu.Items.Add("Сгенерировать пароль\tЛКМ", null, (_, _) => GenerateAndCopy());
            menu.Items.Add("Настройки", null, (_, _) => ShowSettings());
            menu.Items.Add("Выход", null, (_, _) => ExitThread());

            _trayIcon = new NotifyIcon
            {
               Icon = Properties.Resources.PassGen,
                Text = "TrayPassGen – генератор паролей",
                ContextMenuStrip = menu,
                Visible = true
            };

            _trayIcon.MouseClick += (_, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    GenerateAndCopy();
            };
        }

        private void GenerateAndCopy()
        {
            // Выбор символов для генерации
            char[]? symbols = null;
            if (Properties.Settings.Default.UseSafeSymbols)
                symbols = PasswordGenerator.SafeSymbols;
            else if (!Properties.Settings.Default.IncludeSpecialChars)
                symbols = Array.Empty<char>();

            string password = PasswordGenerator.Generate(
                Properties.Settings.Default.PasswordLength,
                Properties.Settings.Default.IncludeLowercase,
                Properties.Settings.Default.IncludeUppercase,
                Properties.Settings.Default.IncludeDigits,
                Properties.Settings.Default.IncludeSpecialChars || Properties.Settings.Default.UseSafeSymbols,
                symbols
            );

            password = Properties.Settings.Default.StaticPrefix + password;

            Clipboard.SetText(password);
            _trayIcon.ShowBalloonTip(2000, "Пароль сгенерирован",
                "Скопировано в буфер обмена:\n" + password, ToolTipIcon.Info);
        }

        private void ShowSettings()
        {
            using var form = new SettingsForm();
            form.ShowDialog();
        }

        protected override void ExitThreadCore()
        {
            _trayIcon.Visible = false;
            _trayIcon.Dispose();
            base.ExitThreadCore();
        }
    }
}
