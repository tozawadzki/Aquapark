using System;
using System.Windows.Forms;
using Aquapark.Forms;
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
            CreateWatch(customerId);
            var watchId = NewWatch.Id;
            if (customerId != 0)
            {
                var entranceId = DbService.GetNewId("Entrances");
                var isSuccess = DbService.InsertData(Query.CreateEntrance(entranceId, watchId, entranceMethod.SelectedIndex + 1, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), customerId, Convert.ToInt32(hours.Text)));
                NewEntrance = new Entrances(entranceId, watchId, entranceMethod.SelectedIndex + 1, DateTime.Now,
                    customerId, Convert.ToInt32(hours.Text));
                if (isSuccess == 1)
                {
                    CreateCharge();
                    return isSuccess;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        private void CreateCharge()
        {
            var newId = DbService.GetNewId("Charges");
            var hours = Convert.ToDecimal(NewEntrance.Hours);
            var discount = Convert.ToDecimal(DbService.GetValue(Query.GetDiscountAmount(NewCustomer.DiscountId)));
            var pricePerHour = Convert.ToDecimal((DbService.GetValue(Query.GetPricePerHour(NewWatch.ServiceId))));
            var chargeAmount = hours * pricePerHour * discount;
            DbService.InsertData(Query.CreateCharge(newId, chargeAmount, NewWatch.Id ));
        }

        private void CreateWatch(int customerId)
        {
            var newId = DbService.GetNewId("Watches");
            var serviceId = service.SelectedIndex+1;
            NewWatch = new Watch(newId, customerId, serviceId);
            DbService.InsertData(Query.CreateWatch(newId, customerId, serviceId));
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
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

    }
}
