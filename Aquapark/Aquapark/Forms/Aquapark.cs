using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Transaction> Transactions;
        public List<Charge> TransactionCharges;
        public Exit Exit;
        private int _elapsedTicks;
        private int _timeLeft;
        private int currentServiceId;
        private DateTime exitTime;
        private Timer tmr = null;
        private Timer tmrelapsed = null;
        private Timer tmrLeft = null;

        public Aquapark()
        {
            InitializeComponent();
            InitializeFields();
            MessageBox.Show("Witamy w Aquaparku!");
            StartTimeElapsed();
            StartTimeLeft();
        }

        private void InitializeFields()
        {
            CurrentCustomer = Entrance.NewCustomer;
            CurrentWatch = Entrance.NewWatch;
            CurrentEntrance = Entrance.NewEntrance;
            Transactions = new List<Transaction>();
            TransactionCharges = new List<Charge>();
            serviceLabel.Text = DbService.GetValue(Query.GetServiceName(CurrentWatch.ServiceId)).ToString();
            currentServiceId = CurrentWatch.ServiceId;
            UpdateServiceTextBox();
            UpdateChargeTextBox();
        }

        private void StartTimeLeft()
        {
            _timeLeft = CurrentEntrance.Hours;
            tmrLeft = new Timer();
            tmrLeft.Interval = 1000;
            tmrLeft.Tick += new EventHandler(timerLeft_Tick);
            tmrLeft.Enabled = true;
            exitTime = DateTime.Now.AddHours(_timeLeft);
            exitTime = DateTime.ParseExact(exitTime.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null);
            labelExitTime.Text = DateTime.Now.AddHours(_timeLeft).ToString();
        }

        private void StartTimeElapsed()
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(timerTime_Tick);
            tmr.Enabled = true;
        }

        private void UpdateChargeTextBox()
        {
            chargeTextBox.Text = DbService.GetValue(Query.GetAllCharges(CurrentWatch.Id)).ToString();
        }

        private void UpdateServiceTextBox()
        {
            serviceLabel.Text = DbService.GetValue(Query.GetServiceName(currentServiceId)).ToString();
        }
        private void CreateTransactionCharge(int serviceId)
        {
            if (serviceId != CurrentWatch.ServiceId)
            {
                var newId = DbService.GetNewId("Charges");
                var amount = GetTransactionChargeAmount(serviceId);
                var watchId = CurrentWatch.Id;
                DbService.InsertData(Query.CreateCharge(newId, amount, watchId));
                var chargeToAdd = new Charge(newId, amount, watchId);
                TransactionCharges.Add(chargeToAdd);
                UpdateChargeTextBox();
            }
        }

        private decimal GetTransactionChargeAmount(int serviceId)
        {
            int minutesSpent = 0;
            if (serviceId == 5)
            {
                minutesSpent = (exitTime - DateTime.Now).Minutes;
            }

            var leaveTime = Transactions.OrderByDescending(x => x.Id).FirstOrDefault().Time;
            var entryTime = Transactions.OrderByDescending(x => x.Id).Where(x => x.TransactionTypeId == 1).FirstOrDefault().Time;
            minutesSpent = (leaveTime - entryTime).Value.Minutes;

            var pricePerMinute = Convert.ToDecimal(DbService.GetValue(Query.GetPricePerMinute(serviceId)));
            return minutesSpent * pricePerMinute;
        }

        private void CreateExit()
        {
            IsClientLate();
            var newId = DbService.GetNewId("Exits");
            var watchId = CurrentWatch.Id;
            var time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            DbService.InsertData(Query.CreateExit(newId, watchId, time));
            Exit = new Exit(newId, watchId, DateTime.Now);
        }

        private void IsClientLate()
        {
            if (exitTime < DateTime.Now)
            {
                CreateTransactionCharge(5);
            }
        }

        private void CreateVisit()
        {
            var newId = DbService.GetNewId("Visits");
            var watchId = CurrentWatch.Id;
            var serviceId = CurrentWatch.ServiceId;
            var customerId = CurrentCustomer.Id;
            var exitPayment = (decimal)Convert.ToInt32(chargeTextBox.Text);
            DbService.InsertData(Query.CreateVisit(newId, watchId, serviceId, customerId, exitPayment));
            Exit = new Exit(newId, watchId, DateTime.Now);
        }

        private void CreateTransaction(int transactionTypeId, int serviceId)
        {
            var newId = DbService.GetNewId("Transactions");
            var watchId = CurrentWatch.Id;
            var time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            DbService.InsertData(Query.CreateTransaction(newId, serviceId, watchId, transactionTypeId, time));
            var transactionToAdd = new Transaction(newId, serviceId, transactionTypeId, watchId, DateTime.Now);
            Transactions.Add(transactionToAdd);
        }

        private void buttonGymEntry_Click(object sender, EventArgs e)
        {
            currentServiceId = 2;
            UpdateServiceTextBox();
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";

            buttonPoolEntry.Visible = false;
            buttonPoolExit.Visible = false;
            buttonSaunaEntry.Visible = false;
            buttonSaunaExit.Visible = false;
            buttonAquaparkEntry.Visible = false;
            buttonAquaparkExit.Visible = false;
            CreateTransaction(1, 2);
        }


        private void buttonGymExit_Click(object sender, EventArgs e)
        {
            currentServiceId = CurrentWatch.ServiceId;
            UpdateServiceTextBox();
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
            buttonPoolEntry.Visible = true;
            buttonPoolExit.Visible = true; ;
            buttonSaunaEntry.Visible = true; 
            buttonSaunaExit.Visible = true; 
            buttonAquaparkExit.Visible = true;
            buttonAquaparkEntry.Visible = true;
            CreateTransaction(2, 2);
            CreateTransactionCharge(2);
        }

        private void buttonPoolEntry_Click(object sender, EventArgs e)
        {
            currentServiceId = 1;
            UpdateServiceTextBox();
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
            buttonGymEntry.Visible = false;
            buttonGymExit.Visible = false;
            buttonSaunaEntry.Visible = false;
            buttonSaunaExit.Visible = false;
            buttonAquaparkEntry.Visible = false;
            buttonAquaparkExit.Visible = false;
            CreateTransaction(1, 1);
        }

        private void buttonPoolExit_Click(object sender, EventArgs e)
        {
            currentServiceId = CurrentWatch.ServiceId;
            UpdateServiceTextBox();
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
            buttonGymEntry.Visible = true;
            buttonGymExit.Visible = true; ;
            buttonSaunaEntry.Visible = true;
            buttonSaunaExit.Visible = true;
            buttonAquaparkExit.Visible = true;
            buttonAquaparkEntry.Visible = true;
            CreateTransaction(2, 1);
            CreateTransactionCharge(1);
        }

        private void buttonSaunaEntry_Click(object sender, EventArgs e)
        {
            currentServiceId = 3;
            UpdateServiceTextBox();
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
            buttonGymEntry.Visible = false;
            buttonGymExit.Visible = false;
            buttonAquaparkEntry.Visible = false;
            buttonAquaparkExit.Visible = false;
            buttonPoolEntry.Visible = false;
            buttonPoolExit.Visible = false;
            CreateTransaction(1, 3);
        }

        private void buttonSaunaExit_Click(object sender, EventArgs e)
        {
            currentServiceId = CurrentWatch.ServiceId;
            UpdateServiceTextBox();
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
            buttonPoolEntry.Visible = true;
            buttonPoolExit.Visible = true; ;
            buttonGymEntry.Visible = true;
            buttonGymExit.Visible = true;
            buttonAquaparkExit.Visible = true;
            buttonAquaparkEntry.Visible = true;
            CreateTransaction(2, 3);
            CreateTransactionCharge(3);
        }

        private void buttonAquaparkEntry_Click(object sender, EventArgs e)
        {
            currentServiceId = 4;
            UpdateServiceTextBox();
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
            buttonGymEntry.Visible = false;
            buttonGymExit.Visible = false;
            buttonSaunaEntry.Visible = false;
            buttonSaunaExit.Visible = false;
            buttonPoolEntry.Visible = false;
            buttonPoolExit.Visible = false;
            CreateTransaction(1, 4);
        }

        private void buttonAquaparkExit_Click(object sender, EventArgs e)
        {
            currentServiceId = CurrentWatch.ServiceId;
            UpdateServiceTextBox();
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
            buttonPoolEntry.Visible = true;
            buttonPoolExit.Visible = true; ;
            buttonSaunaEntry.Visible = true;
            buttonSaunaExit.Visible = true;
            buttonGymExit.Visible = true;
            buttonGymEntry.Visible = true;
            CreateTransaction(2, 4);
            CreateTransactionCharge(4);
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Tables1 tables1Form = new Tables1();
            tables1Form.Show();
            this.Hide();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            CreateExit();
            CreateVisit();
            Application.Exit();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            d = DateTime.ParseExact(d.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null); ;
            labelTimeLeft.Text = (exitTime - d).ToString();
        }
        private void tmrelapsed_Tick(object sender, EventArgs e)
        {
            _elapsedTicks++;
            labelElapsed.Text = _elapsedTicks.ToString() + " min";
        }

    }
}
