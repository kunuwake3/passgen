using System.Drawing;
using System.Windows.Forms;

namespace TrayPassGen
{
    partial class SettingsForm
    {
        private TableLayoutPanel layout;
        private CheckBox cbLower, cbUpper, cbDigits, cbSpecial, cbSafeSymbols;
        private NumericUpDown nudLength;
        private TextBox tbPrefix;
        private Button btnSave;
        private Label lblLength, lblPrefix;

        private void InitializeComponent()
        {
            // ───── макет 2-колоночный, авто-строки ─────
            layout = new TableLayoutPanel {
                Dock       = DockStyle.Fill,
                ColumnCount= 2,
                Padding    = new Padding(20, 15, 20, 15),
                AutoSize   = true
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // ───── чекбоксы ─────
            cbLower       = new CheckBox { Text = "Строчные буквы (a-z)",   AutoSize = true };
            cbUpper       = new CheckBox { Text = "Заглавные буквы (A-Z)",  AutoSize = true };
            cbDigits      = new CheckBox { Text = "Цифры (0-9)",           AutoSize = true };
            cbSpecial     = new CheckBox { Text = "Спецсимволы (!@#$)",    AutoSize = true };
            cbSafeSymbols = new CheckBox { Text = "Только безопасные спецсимволы (_-+=!@#.)", AutoSize = true };

            // ───── длина пароля ─────
            lblLength  = new Label { Text = "Длина пароля:", AutoSize = true, Anchor = AnchorStyles.Left };
            nudLength  = new NumericUpDown {
                Minimum = 4, Maximum = 128, Value = 16,
                Width = 80, Anchor = AnchorStyles.Left
            };
            nudLength.Validating += nudLength_Validating;

            // ───── префикс ─────
            lblPrefix = new Label { Text = "Префикс:", AutoSize = true, Anchor = AnchorStyles.Left };
            tbPrefix  = new TextBox { Anchor = AnchorStyles.Left | AnchorStyles.Right };

            // ───── кнопка ─────
            btnSave = new Button { Text = "Сохранить", Anchor = AnchorStyles.Right, Width = 80 };
            btnSave.Click += btnSave_Click;

            // ───── размещение в таблице ─────
            layout.Controls.Add(cbLower,        0, 0); layout.SetColumnSpan(cbLower, 2);
            layout.Controls.Add(cbUpper,        0, 1); layout.SetColumnSpan(cbUpper, 2);
            layout.Controls.Add(cbDigits,       0, 2); layout.SetColumnSpan(cbDigits, 2);
            layout.Controls.Add(cbSpecial,      0, 3); layout.SetColumnSpan(cbSpecial, 2);
            layout.Controls.Add(cbSafeSymbols,  0, 4); layout.SetColumnSpan(cbSafeSymbols, 2);

            layout.Controls.Add(lblLength, 0, 5); layout.Controls.Add(nudLength, 1, 5);
            layout.Controls.Add(lblPrefix, 0, 6); layout.Controls.Add(tbPrefix,  1, 6);

            layout.Controls.Add(btnSave,  1, 7);
            layout.RowStyles.Add(new RowStyle()); // авто для всех строк
            layout.RowStyles.Add(new RowStyle());
            layout.RowStyles.Add(new RowStyle());
            layout.RowStyles.Add(new RowStyle());
            layout.RowStyles.Add(new RowStyle());
            layout.RowStyles.Add(new RowStyle());
            layout.RowStyles.Add(new RowStyle());
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // для кнопки

            // ───── сама форма ─────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize    = new Size(860, 440);
            MinimumSize   = new Size(860, 440);
            Controls.Add(layout);
            Text = "Настройки генератора";
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
