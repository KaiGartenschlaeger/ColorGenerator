using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorGenerator
{
    public partial class FormMain : Form
    {
        Random _random;

        public FormMain()
        {
            InitializeComponent();

            _random = new Random();
        }

        public Color GenerateRandomColor(Color mix)
        {
            Random random = new Random();
            int red = _random.Next(0, 257);
            int green = _random.Next(0, 257);
            int blue = _random.Next(0, 257);

            // mix the color
            if (mix != null)
            {
                red = (red + mix.R) / 2;
                green = (green + mix.G) / 2;
                blue = (blue + mix.B) / 2;
            }

            Color color = Color.FromArgb((byte)red, (byte)green, (byte)blue);
            return color;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            flpColors.Controls.Clear();

            for (int i = 0; i < (int)nudAmount.Value; i++)
            {
                Panel panColor = new Panel();
                panColor.BackColor = GenerateRandomColor(Color.White);
                panColor.Margin = new Padding(3);
                panColor.Size = new Size(50, 25);

                CheckBox chbSelect = new CheckBox();
                chbSelect.Size = new Size(panColor.Width, panColor.Height);
                chbSelect.Location = new Point(5, 0);
                chbSelect.FlatStyle = FlatStyle.Flat;
                chbSelect.FlatAppearance.BorderColor = Color.Black;
                chbSelect.FlatAppearance.BorderSize = 1;

                panColor.Controls.Add(chbSelect);

                flpColors.Controls.Add(panColor);
            }
        }

        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in flpColors.Controls)
            {
                ((CheckBox)control.Controls[0]).Checked = chbSelectAll.Checked;
            }
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            StringBuilder code = new StringBuilder();

            code.AppendLine("Color[] colors = new Color[]");
            code.AppendLine("{");

            foreach (Control control in flpColors.Controls)
            {
                if (((CheckBox)control.Controls[0]).Checked)
                {
                    code.AppendFormat("    Color.FromArgb({0}, {1}, {2}),",
                        control.BackColor.R,
                        control.BackColor.G,
                        control.BackColor.B);

                    code.AppendLine();
                }
            }

            code.Append("};");

            using (FormCode dialog = new FormCode(code.ToString()))
            {
                dialog.ShowDialog(this);
            }
        }
    }
}