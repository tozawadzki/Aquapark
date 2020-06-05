using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquapark.Forms
{
    public partial class Login : Form
    {
        public const string Username = "admin";
        public const string Password = "admin";
        public Login()
        {
            InitializeComponent();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;
            if (login == Username && password == Password)
            {
                Tables1 tables1Form = new Tables1();
                tables1Form.Show();
                this.Hide();
            }
        }
    }
}
