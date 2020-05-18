using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
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
                var connectionString = "Data Source=XE;User Id=Aquapark;Password=7zmty6q2e;";
                using (var connection = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionString))
                {
                    connection.Open();
                    var command = new Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM Aquapark.Customers", connection);
                    var oracleDataAdapter = new Oracle.ManagedDataAccess.Client.OracleDataAdapter(command);
                    var dataSet = new DataSet();
                    oracleDataAdapter.Fill(dataSet);
                    if (dataSet.Tables.Count > 0)
                    {
                        customersGridView.DataSource = dataSet.Tables[0].DefaultView;
                    }
                }
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