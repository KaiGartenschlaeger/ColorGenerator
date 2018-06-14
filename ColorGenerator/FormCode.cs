using System.Windows.Forms;

namespace ColorGenerator
{
    public partial class FormCode : Form
    {
        public FormCode(string code)
        {
            InitializeComponent();

            textBox1.Text = code;
        }
    }
}