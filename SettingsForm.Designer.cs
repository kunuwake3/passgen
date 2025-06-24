namespace TrayPassGen
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbDigits;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.CheckBox cbSafeSymbols;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelPrefix;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cbLower = new System.Windows.Forms.CheckBox();
            cbUpper = new System.Windows.Forms.CheckBox();
            cbDigits = new System.Windows.Forms.CheckBox();
            cbSpecial = new System.Windows.Forms.CheckBox();
            cbSafeSymbols = new System.Windows.Forms.CheckBox();
            nudLength = new System.Windows.Forms.NumericUpDown();
            tbPrefix = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            labelLength = new System.Windows.Forms.Label();
            labelPrefix = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(nudLength)).BeginInit();
            SuspendLayout();

            // Чекбоксы
            cbLower.Text = "Строчные буквы (a-z)";
            cbLower.Location = new System.Drawing.Point(12, 12);
            cbLower.AutoSize = true;

            cbUpper.Text = "Заглавные буквы (A-Z)";
            cbUpper.Location = new System.Drawing.Point(12, 35);
            cbUpper.AutoSize = true;

            cbDigits.Text = "Цифры (0-9)";
            cbDigits.Location = new System.Drawing.Point(12, 58);
            cbDigits.AutoSize = true;

            cbSpecial.Text = "Спецсимволы (!@#$)";
            cbSpecial.Location = new System.Drawing.Point(12, 81);
            cbSpecial.AutoSize = true;

            cbSafeSymbols.Text = "Только безопасные спецсимволы (_-+=!@#.)";
            cbSafeSymbols.Location = new System.Drawing.Point(12, 104);
            cbSafeSymbols.AutoSize = true;

            // Длина
            labelLength.Text = "Длина пароля:";
            labelLength.Location = new System.Drawing.Point(12, 135);
            labelLength.AutoSize = true;

            nudLength.Location = new System.Drawing.Point(120, 133);
            nudLength.Minimum = 4;
            nudLength.Maximum = 128;
            nudLength.Value = 16;

            // Префикс
            labelPrefix.Text = "Префикс:";
            labelPrefix.Location = new System.Drawing.Point(12, 162);
            labelPrefix.AutoSize = true;

            tbPrefix.Location = new System.Drawing.Point(120, 159);
            tbPrefix.Width = 140;

            // Сохранить
            btnSave.Text = "Сохранить";
            btnSave.Location = new System.Drawing.Point(90, 195);
            btnSave.Click += new System.EventHandler(btnSave_Click);

            // Форма
            ClientSize = new System.Drawing.Size(300, 240);
            Controls.AddRange(new Control[]
            {
                cbLower, cbUpper, cbDigits, cbSpecial, cbSafeSymbols,
                labelLength, nudLength, labelPrefix, tbPrefix,
                btnSave
            });

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Настройки генератора";
            StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(nudLength)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
