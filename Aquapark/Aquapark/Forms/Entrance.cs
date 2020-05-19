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
            discount.DataSource = DbService.GetValuesForDropdown(Query.GetDiscountNames);
            service.DataSource = DbService.GetValuesForDropdown(Query.GetServiceNames);
            entranceMethod.DataSource = DbService.GetValuesForDropdown(Query.GetEntranceMethodNames);
        }

        private int CreateCustomer()
        {
            var newCustomerId = Convert.ToInt32(DbService.GetValuesForDropdown(Query.GetLastIdFromTable("Customers")).ToList().FirstOrDefault()) + 1;
            DbService.InsertData(Query.CreateCustomer(newCustomerId, firstName.Text, lastName.Text, discount.SelectedIndex+1));
            return newCustomerId;
        }
        private void CreateEntrance()
        {
            DbService.InsertData(Query.CreateEntrance(1, 1, entranceMethod.SelectedIndex+1, DateTime.Now, CreateCustomer(), Convert.ToInt32(hours.Text)));
        }
        private void entryButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateCustomer();
                //CreateEntrance();
                Aquapark aquaparkForm = new Aquapark();
                aquaparkForm.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
