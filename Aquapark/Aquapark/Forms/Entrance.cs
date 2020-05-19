using System;
using System.Linq;
using System.Windows.Forms;
using Aquapark.Services;

namespace Aquapark
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
            service.DataSource = DbService.GetValuesForDropdown(Query.GetServiceNames);
            discount.DataSource = DbService.GetValuesForDropdown(Query.GetDiscountNames);
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
            var newEntranceId = Convert.ToInt32(DbService.GetValuesForDropdown(Query.GetLastIdFromTable("Entrances")).ToList().FirstOrDefault()) + 1;
            var watchId = Convert.ToInt32(DbService.GetValuesForDropdown(Query.GetLastIdFromTable("Watches")).ToList().FirstOrDefault());
            DbService.InsertData(Query.CreateEntrance(newEntranceId, watchId, entranceMethod.SelectedIndex+1, DateTime.Now, CreateCustomer(), Convert.ToInt32(hours.Text)));
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

        private void adminButton_Click(object sender, EventArgs e)
        {
            Tables1 tables1Form = new Tables1();
            tables1Form.Show();
            this.Hide();
        }
    }
}
