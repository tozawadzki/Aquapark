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
        private int _ticks;
        
        public Aquapark()
        {
            InitializeComponent();
            InitializeFields();
            MessageBox.Show("Witamy w Aquaparku!");
            StartTimer();
        }

        private void InitializeFields()
        {
            CurrentCustomer = Entrance.NewCustomer;
            CurrentWatch = Entrance.NewWatch;
            CurrentEntrance = Entrance.NewEntrance;
            serviceLabel.Text = CurrentWatch.ServiceId.ToString(); // Ma być tak, nie działa z niewiadomych powodów -> DbService.GetValuesForDropdown(Query.GetServiceName(CurrentWatch.ServiceId))[0];
            watchIdLabel.Text = CurrentWatch.Id.ToString();
            chargeTextBox.Text = DbService.GetValuesForDropdown(Query.GetAllCharges(CurrentWatch.Id))[0];
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

        System.Windows.Forms.Timer tmr = null;
        System.Windows.Forms.Timer tmrelapsed = null;

        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 60000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToString();
        }

        private void buttonGymEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new System.Windows.Forms.Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _ticks = 0;
            textBoxElapsed.Text = "0 min";
        }


        private void tmrelapsed_Tick(object sender, EventArgs e)
        {
            _ticks++;
            textBoxElapsed.Text = _ticks.ToString() + " min";
        }

        private void buttonGymExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            textBoxElapsed.Text = " ";
        }

        private void buttonPoolEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new System.Windows.Forms.Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _ticks = 0;
            textBoxElapsed.Text = "0 min";
        }

        private void buttonPoolExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            textBoxElapsed.Text = " ";
        }

        private void buttonSaunaEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new System.Windows.Forms.Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _ticks = 0;
            textBoxElapsed.Text = "0 min";
        }

        private void buttonSaunaExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            textBoxElapsed.Text = " ";
        }

        private void buttonAquaparkEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new System.Windows.Forms.Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _ticks = 0;
            textBoxElapsed.Text = "0 min";
        }

        private void buttonAquaparkExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            textBoxElapsed.Text = " ";
        }

        private void buttonServiceEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new System.Windows.Forms.Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _ticks = 0;
            textBoxElapsed.Text = "0 min";
        }

        private void buttonServiceExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            textBoxElapsed.Text = " ";
        }
    }
}
