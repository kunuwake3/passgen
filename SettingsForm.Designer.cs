using System.Drawing;
using System.Windows.Forms;

namespace TrayPassGen
{
    partial class SettingsForm
    {
        private NumericUpDown nudLength;
        private TextBox       tbPrefix;
        private CheckBox      cbLower;
        private CheckBox      cbUpper;
        private CheckBox      cbDigits;
        private CheckBox      cbSpecial;
        private CheckBox      cbSafeSymbols;
        private Button        btnSave;
        private Label         labelLength;
        private Label         labelPrefix;

        private void InitializeComponent()
        {
            nudLength      = new NumericUpDown();
            tbPrefix       = new TextBox();
            cbLower        = new CheckBox();
            cbUpper        = new CheckBox();
            cbDigits       = new CheckBox();
            cbSpecial      = new CheckBox();
            cbSafeSymbols  = new CheckBox();
            btnSave        = new Button();
            labelLength    = new Label();
            labelPrefix    = new Label();
            ((System.ComponentModel.ISupportInitialize)(nudLength)).BeginInit();
            SuspendLayout();

            // ─── Чекбоксы ──────────────────────────────────────────────
            cbLower.Text     = "Строчные буквы (a-z)";
            cbLower.Location = new Point(14, 14);
            cbLower.AutoSize = true;

            cbUpper.Text     = "Заглавные буквы (A-Z)";
            cbUpper.Location = new Point(14, 39);
            cbUpper.AutoSize = true;

            cbDigits.Text     = "Цифры (0-9)";
            cbDigits.Location = new Point(14, 64);
            cbDigits.AutoSize = true;

            cbSpecial.Text     = "Спецсимволы (!@#$)";
            cbSpecial.Location = new Point(14, 89);
            cbSpecial.AutoSize = true;

            cbSafeSymbols.Text     = "Только безопасные спецсимволы (_-+=!@#.)";
            cbSafeSymbols.Location = new Point(14, 114);
            cbSafeSymbols.AutoSize = true;

            // ─── Длина пароля ──────────────────────────────────────────
            labelLength.Text     = "Длина пароля:";
            labelLength.Location = new Point(14, 151);
            labelLength.AutoSize = true;

            nudLength.Location = new Point(125, 149);
            nudLength.Size     = new Size(60, 23);
            nudLength.Minimum  = 4;
            nudLength.Maximum  = 128;
            nudLength.Value    = 16;
            nudLength.Anchor   = AnchorStyles.Top | AnchorStyles.Left;
            nudLength.Validating += nudLength_Validating;

            // ─── Префикс ───────────────────────────────────────────────
            labelPrefix.Text     = "Префикс:";
            labelPrefix.Location = new Point(14, 183);
            labelPrefix.AutoSize = true;

            tbPrefix.Location = new Point(125, 180);
            tbPrefix.Size     = new Size(260, 23);
            tbPrefix.Anchor   = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // ─── Кнопка Сохранить ─────────────────────────────────────
            btnSave.Text   = "Сохранить";
            btnSave.Size   = new Size(90, 30);
            btnSave.Location = new Point(295, 260);
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Click += btnSave_Click;

            // ─── Форма ────────────────────────────────────────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize    = new Size(420, 320);
            MinimumSize   = new Size(420, 320);
            Controls.AddRange(new Control[]
            {
                cbLower, cbUpper, cbDigits, cbSpecial, cbSafeSymbols,
                labelLength, nudLength, labelPrefix, tbPrefix, btnSave
            });
            Font            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            MinimizeBox     = false;
            StartPosition   = FormStartPosition.CenterScreen;
            Text            = "Настройки генератора";

            ((System.ComponentModel.ISupportInitialize)(nudLength)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
