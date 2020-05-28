using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Aquapark.Services
{
    public class DbService
    {
        private const string connectionData = "Data Source=XE;User Id=aquapark;Password=7zmty6q2e;";
        public static DataSet GetData(string query)
        {
            var connectionString = connectionData;
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                var command = new OracleCommand(query, connection);
                var oracleDataAdapter = new OracleDataAdapter(command);
                var dataSet = new DataSet();
                oracleDataAdapter.Fill(dataSet);
                connection.Close();
                if (dataSet.Tables.Count > 0)
                {
                    return dataSet;
                }
            }
            return null;
        }

        public static int InsertData(string query)
        {
            try
            {
                var connectionString = connectionData;
                using (var connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    var command = new OracleCommand(query, connection);
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    return result;
                }
            }
            catch (OracleException ex)
            {
                string errorMessage = "Kod błędu: " + ex.ErrorCode + "\n" +
                                      "Komunikat: " + ex.Message;
                MessageBox.Show(errorMessage);
                return 0;
            }
        }

        public static List<string> GetValuesForDropdown(string query)
        {
            var result = DbService.GetData(query);
            var values = new List<string>();
            foreach (DataRow row in result.Tables[0].Rows)
            {
                var item = string.Join(",", row.ItemArray);
                values.Add(item);
            }
            return values;
        }

        public static int GetNewId(string table)
        {
            var lastId = GetValue(Query.GetLastIdFromTable(table));
            if (lastId == null)
                return 1;
            else
            {
                var id = Convert.ToInt32(lastId) + 1;
                return id;
            }
        }

        public static object GetValue(string query)
        {
            var connectionString = connectionData;
            using (var connection = new OracleConnection(connectionString))
            {
                var command = new OracleCommand(query, connection);
                connection.Open();
                var value = command.ExecuteScalar();
                connection.Close();
                return value;
            }
        }
        public static int IsSuccess(int isSuccess, int Id)
        {
            if (isSuccess == 1)
                return Id;
            return 0;
        }
    }
}
