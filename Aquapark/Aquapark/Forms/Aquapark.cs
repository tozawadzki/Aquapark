﻿using System;
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
        public Exit Exit;
        private int _elapsedTicks;
        private int _timeLeft;
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
            serviceLabel.Text = DbService.GetValue(Query.GetServiceName(CurrentWatch.ServiceId)).ToString();
            chargeTextBox.Text = DbService.GetValue(Query.GetAllCharges(CurrentWatch.Id)).ToString();
        }

        private void StartTimeLeft()
        {
            _timeLeft = CurrentEntrance.Hours;
            tmrLeft = new Timer();
            tmrLeft.Interval = 1000;
            tmrLeft.Tick -= new EventHandler(timerLeft_Tick);
            tmrLeft.Enabled = true;
        }

        private void StartTimeElapsed()
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(timerTime_Tick);
            tmr.Enabled = true;
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

        private void CreateExit()
        {
            var newId = DbService.GetNewId("Exits");
            var watchId = CurrentWatch.Id;
            var time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            DbService.InsertData(Query.CreateExit(newId, watchId, time));
            Exit = new Exit(newId, watchId, DateTime.Now);
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

        private void buttonGymEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
        }

        private void tmrelapsed_Tick(object sender, EventArgs e)
        {
            _elapsedTicks++;
            labelElapsed.Text = _elapsedTicks.ToString() + " min";
        }

        private void buttonGymExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
        }

        private void buttonPoolEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
        }

        private void buttonPoolExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
        }

        private void buttonSaunaEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
        }

        private void buttonSaunaExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
        }

        private void buttonAquaparkEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
        }

        private void buttonAquaparkExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
        }

        private void buttonServiceEntry_Click(object sender, EventArgs e)
        {
            tmrelapsed = new Timer();
            tmrelapsed.Interval = 60000;
            tmrelapsed.Tick += new EventHandler(tmrelapsed_Tick);
            tmrelapsed.Start();
            _elapsedTicks = 0;
            labelElapsed.Text = "0 min";
        }

        private void buttonServiceExit_Click(object sender, EventArgs e)
        {
            tmrelapsed.Stop();
            tmrelapsed.Start();
            tmrelapsed.Stop();
            labelElapsed.Text = " ";
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void Aquapark_Load(object sender, EventArgs e)
        {

        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            labelTimeLeft.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
