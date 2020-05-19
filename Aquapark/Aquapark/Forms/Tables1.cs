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
                customersGridView.DataSource = DbConnection.GetData(Query.GetGustomers).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}