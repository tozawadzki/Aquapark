using System;
using System.Windows.Forms;

namespace Aquapark
{
    public partial class Aquapark : Form
    {
        public Aquapark()
        {
            InitializeComponent();
            MessageBox.Show("Witamy w Aquaparku!");
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Tables1 tables1Form = new Tables1();
            tables1Form.Show();
            this.Hide();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
