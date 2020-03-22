using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Aquapark
{
    public partial class Aquapark : Form
    {
        public Aquapark()
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
                //ac chyba jednak nie ogarniemy tego tak bo ja nie moge odpalać i nie iwdzie jaki masz bledy, musimy ogarn team viewera 
                //
                var connectionString = "Data Source=XE;User Id=aquapark;Password=123;";
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
    }
}