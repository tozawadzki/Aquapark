using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using Aquapark.Services;
using Oracle.ManagedDataAccess.Client;

namespace Aquapark
{
    public partial class Tables1 : Form
    {
        public Tables1()
        {
            InitializeComponent();
        }

        private void Aquapark_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                customersGridView.DataSource = DbService.GetData(Query.GetGustomers).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void page2Button_Click(object sender, EventArgs e)
        {
            Tables2 tables2Form = new Tables2();
            tables2Form.Show();
            this.Hide();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            Aquapark aquaparkForm = new Aquapark();
            aquaparkForm.Show();
            this.Hide();
        }
    }
}