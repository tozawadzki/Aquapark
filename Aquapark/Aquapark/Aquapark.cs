using System;
using System.Collections.Generic;
using System.Data;
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
                var connectionString = "Data Source=XE;User Id=Aquapark;Password=7zmty6q2e;";
                using (var connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    var command = new OracleCommand("SELECT * FROM Aquapark.Customers", connection);
                    var oracleDataAdapter = new OracleDataAdapter(command);
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