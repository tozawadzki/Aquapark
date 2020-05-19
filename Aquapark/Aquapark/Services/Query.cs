using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark.Services
{
    public class Query
    {
        public static string GetGustomers =
            "SELECT * FROM Customers";

        public static string GetTransactions =
            "SELECT * FROM Transactions";

        public static string GetTransactionTypes =
            "SELECT * FROM TransactionTypes";

        public static string GetEntrances =
            "SELECT * FROM Entrances";

        public static string GetEntranceMethods =
            "SELECT * FROM EntranceMethods";

        public static string GetExits =
            "SELECT * FROM Exits";

        public static string GetServices =
            "SELECT * FROM Services";

        public static string GetWatches =
            "SELECT * FROM Watches";

        public static string GetDiscounts =
            "SELECT * FROM Discounts";

        public static string GetCharges =
            "SELECT * FROM Charges";

        public static string GetVisits =
            "SELECT * FROM Visits";

        public static string GetDiscountNames
            = "SELECT Name from Discounts";

        public static string GetDiscountId(string discountName)
        {
            var query = $"SELECT Id FROM Discounts WHERE Name == {discountName}";
            return query;
        }
        
        public static string GetCustomerDiscount(int customerId)
        {
            var query = 
                $"SELECT Amount FROM Aquapark.Discounts WHERE Discounts.Id == {customerId}";
            return query;
        }

        public static string CreateCustomer(int customerId, string firstName, string lastName, int discountId)
        {
            var query =
                $"INSERT INTO Customers(Id, FirstName, LastName, DiscountId) VALUES ({customerId}, {firstName}, {lastName}, {discountId})";
            return query;
        }
    }
}
