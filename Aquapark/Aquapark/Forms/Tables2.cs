using System;
using System.Windows.Forms;

namespace Aquapark
{
    public partial class Tables2 : Form
    {
        public Tables2()
        {
            InitializeComponent();
        }

        private void page1Button_Click(object sender, EventArgs e)
        {
            Tables1 tables1Form = new Tables1();
            tables1Form.Show();
            this.Hide();
        }
    }
}
