using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aquapark.Services;

namespace Aquapark
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
            discount.DataSource = DbConnection.GetDiscountsForDropdown(Query.GetDiscountNames);
        }

        private void CreateCustomer()
        {
            DbConnection.InsertData(Query.CreateCustomer(4, firstName.Text, lastName.Text, discount.SelectedIndex+1));
        }
        private void entryButton_Click(object sender, EventArgs e)
        {
            CreateCustomer();
        }
    }
}
