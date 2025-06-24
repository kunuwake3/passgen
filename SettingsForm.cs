using System;
using System.Windows.Forms;

namespace TrayPassGen
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            // Загрузка текущих настроек
            AutoScaleMode = AutoScaleMode.Dpi;
            cbLower.Checked = Properties.Settings.Default.IncludeLowercase;
            cbUpper.Checked = Properties.Settings.Default.IncludeUppercase;
            cbDigits.Checked = Properties.Settings.Default.IncludeDigits;
            cbSpecial.Checked = Properties.Settings.Default.IncludeSpecialChars;
            cbSafeSymbols.Checked = Properties.Settings.Default.UseSafeSymbols;
            nudLength.Value = Properties.Settings.Default.PasswordLength;
            tbPrefix.Text = Properties.Settings.Default.StaticPrefix;

            cbSafeSymbols.CheckedChanged += (_, _) =>
            {
                cbSpecial.Enabled = !cbSafeSymbols.Checked;
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Сохранение
            Properties.Settings.Default.IncludeLowercase = cbLower.Checked;
            Properties.Settings.Default.IncludeUppercase = cbUpper.Checked;
            Properties.Settings.Default.IncludeDigits = cbDigits.Checked;
            Properties.Settings.Default.IncludeSpecialChars = cbSpecial.Checked;
            Properties.Settings.Default.UseSafeSymbols = cbSafeSymbols.Checked;
            Properties.Settings.Default.PasswordLength = (int)nudLength.Value;
            Properties.Settings.Default.StaticPrefix = tbPrefix.Text;
            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
