using System;
using System.Windows.Forms;
using Aquapark.Models;
using Aquapark.Services;

namespace Aquapark
{
    public partial class Aquapark : Form
    {
        public Customer CurrentCustomer;
        public Watch CurrentWatch;
        public Entrances CurrentEntrance;
        public Aquapark()
        {
            InitializeComponent();
            InitializeFields();
            MessageBox.Show("Witamy w Aquaparku!");
        }

        private void InitializeFields()
        {
            CurrentCustomer = Entrance.NewCustomer;
            CurrentWatch = Entrance.NewWatch;
            CurrentEntrance = Entrance.NewEntrance;
            serviceLabel.Text = CurrentWatch.ServiceId.ToString(); // Ma być tak, nie działa z niewiadomych powodów -> DbService.GetValuesForDropdown(Query.GetServiceName(CurrentWatch.ServiceId))[0];
            watchIdLabel.Text = CurrentWatch.Id.ToString();
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
