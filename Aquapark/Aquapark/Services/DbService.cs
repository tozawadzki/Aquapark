using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquapark.Services
{
    public class DbService
    {
        private const string connectionData = "Data Source=XE;User Id=Aquapark;Password=7zmty6q2e;";
        public static DataSet GetData(string query)
        {
            var connectionString = connectionData;
            using (var connection = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionString))
            {
                connection.Open();
                var command = new Oracle.ManagedDataAccess.Client.OracleCommand(query, connection);
                var oracleDataAdapter = new Oracle.ManagedDataAccess.Client.OracleDataAdapter(command);
                var dataSet = new DataSet();
                oracleDataAdapter.Fill(dataSet);
                if (dataSet.Tables.Count > 0)
                {
                    return dataSet;
                }
            }
            return null;
        }

        public static void InsertData(string query)
        {
            try
            {
                var connectionString = connectionData;
                using (var connection = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionString))
                {
                    connection.Open();
                    var command = new Oracle.ManagedDataAccess.Client.OracleCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static List<string> GetValuesForDropdown(string query)
        {
            var result = DbService.GetData(query);
            var values = new List<string>();
            foreach (DataRow row in result.Tables[0].Rows)
            {
                var discountName = string.Join(",", row.ItemArray);
                values.Add(discountName);
            }
            return values;
        }

    }
}
