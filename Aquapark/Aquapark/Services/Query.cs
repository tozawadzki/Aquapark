using System;

namespace Aquapark.Services
{
    public class Query
    {
        public static string GetGustomers =
            "SELECT * FROM Customers ORDER BY Id";

        public static string GetTransactions =
            "SELECT * FROM Transactions ORDER BY Id";

        public static string GetTransactionTypes =
            "SELECT * FROM TransactionTypes ORDER BY Id";

        public static string GetEntrances =
            "SELECT * FROM Entrances ORDER BY Id";

        public static string GetEntranceMethods =
            "SELECT * FROM EntranceMethods ORDER BY Id";

        public static string GetExits =
            "SELECT * FROM Exits ORDER BY Id";

        public static string GetServices =
            "SELECT * FROM Services ORDER BY Id";

        public static string GetWatches =
            "SELECT * FROM Watches ORDER BY Id";

        public static string GetDiscounts =
            "SELECT * FROM Discounts ORDER BY Id";

        public static string GetCharges =
            "SELECT * FROM Charges ORDER BY Id";

        public static string GetVisits =
            "SELECT * FROM Visits ORDER BY Id";

        public static string GetDiscountNames
            = "SELECT Name FROM Discounts";

        public static string GetServiceNames
            = "SELECT Name FROM Services";

        public static string GetEntranceMethodNames
            = "SELECT Name FROM EntranceMethod";

        public static string GetLastIdFromTable(string tableName)
        {
            var query = $"SELECT MAX(Id) FROM {tableName}";
            return query;
        }
        public static string CreateCustomer(int customerId, string firstName, string lastName, int discountId)
        {
            var query =
                $"INSERT INTO Customers(Id, FirstName, LastName, DiscountId) VALUES ({customerId}, '{firstName}', '{lastName}', {discountId})";
            return query;
        }
        public static string CreateEntrance(int entranceId, int watchId, int entranceMethodId, DateTime time, int customerId, int hours)
        {
            var query =
                $"INSERT INTO Customers(Id, FirstName, LastName, DiscountId) VALUES ({entranceId}, {watchId}, {entranceMethodId}, {time}, {customerId}, {hours})";
            return query;
        }
    }
}
