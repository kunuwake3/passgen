using System.Drawing;
using System.Windows.Forms;

namespace TrayPassGen
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private CheckBox cbLower;
        private CheckBox cbUpper;
        private CheckBox cbDigits;
        private CheckBox cbSpecial;
        private CheckBox cbSafeSymbols;
        private NumericUpDown nudLength;
        private TextBox tbPrefix;
        private Button btnSave;
        private Label labelLength;
        private Label labelPrefix;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cbLower      = new CheckBox();
            cbUpper      = new CheckBox();
            cbDigits     = new CheckBox();
            cbSpecial    = new CheckBox();
            cbSafeSymbols = new CheckBox();
            nudLength    = new NumericUpDown();
            tbPrefix     = new TextBox();
            btnSave      = new Button();
            labelLength  = new Label();
            labelPrefix  = new Label();

            ((System.ComponentModel.ISupportInitialize)(nudLength)).BeginInit();
            SuspendLayout();

            // ───── Чекбоксы ───────────────────────────────────────────────────
            cbLower.Text = "Строчные буквы (a-z)";
            cbLower.Location = new Point(12, 12);
            cbLower.AutoSize = true;

            cbUpper.Text = "Заглавные буквы (A-Z)";
            cbUpper.Location = new Point(12, 35);
            cbUpper.AutoSize = true;

            cbDigits.Text = "Цифры (0-9)";
            cbDigits.Location = new Point(12, 58);
            cbDigits.AutoSize = true;

            cbSpecial.Text = "Спецсимволы (!@#$)";
            cbSpecial.Location = new Point(12, 81);
            cbSpecial.AutoSize = true;

            cbSafeSymbols.Text = "Только безопасные спецсимволы (_-+=!@#.)";
            cbSafeSymbols.Location = new Point(12, 104);
            cbSafeSymbols.AutoSize = true;

            // ───── Длина ─────────────────────────────────────────────────────
            labelLength.Text = "Длина пароля:";
            labelLength.Location = new Point(12, 135);
            labelLength.AutoSize = true;

            nudLength.Location = new Point(120, 133);
            nudLength.Minimum  = 4;
            nudLength.Maximum  = 128;
            nudLength.Value    = 16;               // после Min/Max!
            nudLength.Anchor   = AnchorStyles.Top | AnchorStyles.Left;
            nudLength.Validating += nudLength_Validating;

            // ───── Префикс ───────────────────────────────────────────────────
            labelPrefix.Text = "Префикс:";
            labelPrefix.Location = new Point(12, 162);
            labelPrefix.AutoSize = true;

            tbPrefix.Location = new Point(120, 159);
            tbPrefix.Width    = 230;
            tbPrefix.Anchor   = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // ───── Кнопка Сохранить ─────────────────────────────────────────
            btnSave.Text = "Сохранить";
            btnSave.Size = new Size(90, 30);
            btnSave.Location = new Point(275, 245);
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Click += btnSave_Click;

            // ───── Форма ─────────────────────────────────────────────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize    = new Size(380, 300);
            MinimumSize   = new Size(380, 300);
            Controls.AddRange(new Control[]
            {
                cbLower, cbUpper, cbDigits, cbSpecial, cbSafeSymbols,
                labelLength, nudLength, labelPrefix, tbPrefix, btnSave
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Настройки генератора";
            StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(nudLength)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ───── Проверка поля длины ──────────────────────────────────────────
        private void nudLength_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nudLength.Value < 4 || nudLength.Value > 128)
            {
                e.Cancel = true;
                MessageBox.Show("Длина пароля должна быть от 4 до 128 символов.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
