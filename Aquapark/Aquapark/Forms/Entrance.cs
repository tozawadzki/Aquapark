using System;
using System.Windows.Forms;
using Aquapark.Models;
using Aquapark.Services;

namespace Aquapark
{
    public partial class Entrance : Form
    {
        public static Customer NewCustomer;
        public static Watch NewWatch;
        public static Entrances NewEntrance;
        public Entrance()
        {
            InitializeComponent();
            InitializeTables();
        }

        private void InitializeTables()
        {
            service.DataSource = DbService.GetValuesForDropdown(Query.GetServiceNames);
            discount.DataSource = DbService.GetValuesForDropdown(Query.GetDiscountNames);
            entranceMethod.DataSource = DbService.GetValuesForDropdown(Query.GetEntranceMethodNames);
        }

        private int CreateCustomer()
        {
            var newId = DbService.GetNewId("Customers");
            var isSuccess = DbService.InsertData(Query.CreateCustomer(newId, firstName.Text, lastName.Text, discount.SelectedIndex + 1));
            NewCustomer = new Customer(newId, discount.SelectedIndex + 1, firstName.Text, lastName.Text);
            return DbService.IsSuccess(isSuccess, newId);
        }

        private int CreateEntrance()
        {
            var customerId = CreateCustomer();
            var watchId = CreateWatch(customerId);
            if (customerId != 0)
            {
                var entranceId = DbService.GetNewId("Entrances");
                var isSuccess = DbService.InsertData(Query.CreateEntrance(entranceId, watchId, entranceMethod.SelectedIndex + 1, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), customerId, Convert.ToInt32(hours.Text)));
                NewEntrance = new Entrances(entranceId, watchId, entranceMethod.SelectedIndex + 1, DateTime.Now,
                    customerId, Convert.ToInt32(hours.Text));
                return DbService.IsSuccess(isSuccess, entranceId);
            }

            return 0;
        }

        private int CreateWatch(int customerId)
        {
            var newId = DbService.GetNewId("Watches");
            var serviceId = service.SelectedIndex+1;
            NewWatch = new Watch(newId, customerId, serviceId);
            return DbService.InsertData(Query.CreateWatch(newId, customerId, serviceId));
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            if (CreateEntrance() != 0)
            {
                Aquapark aquaparkForm = new Aquapark();
                aquaparkForm.Show();
                this.Hide();
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
