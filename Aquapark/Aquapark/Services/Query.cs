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
        public static string CreateEntrance(int entranceId, int watchId, int entranceMethodId, string time, int customerId, int hours)
        {
            var query =
                $"INSERT INTO Entrances(Id, WatchId, EntranceMethodId, Time, CustomerId, Hours) VALUES ({entranceId}, {watchId}, {entranceMethodId}, '{time}', {customerId}, {hours})";
            return query;
        }

        public static string CreateWatch(int watchId, int customerId, int serviceId)
        {
            var query =
                $"INSERT INTO Watches(Id, CustomerId, ServiceId) VALUES ({watchId}, {customerId}, {serviceId})";
            return query;
        }

        public static string GetCustomerDiscount(int customerId)
        {
            var query =
            $"SELECT Discounts.amount FROM Discounts WHERE discounts.id = ({customerId})";
            return query;
        }

        public static string GetTransactionType(int TransactionTypeId)
        {
            var query =
            $"SELECT TransactionType.name FROM transactiontype WHERE transactiontype.id = {TransactionTypeId};";
            return query;
        }

        public static string CreateTransaction(int Id, int ServiceId, int WatchId, int TransactionTypeId, DateTime time)
        {
            var query =
            $"INSERT INTO TRANSACTION (Id, Serviceid, TransactionTypeId, time) VALUES({Id}, {ServiceId}, {WatchId}, {TransactionTypeId}, {time};"; //
            return query;
        }

        public static string GetListOfTransactions(int WatchId)
        {
            var query =
            $"SELECT * FROM transaction WHERE watchid = {WatchId};";
            return query;
        }

        public static string DeleteTransactions(int WatchId)
        {
            var query =
            $"DELETE * FROM transaction WHERE watchid = {WatchId};";
            return query;
        }

        public static string GetPricePerHour(int ServiceId)
        {
            var query =
            $"SELECT Services.priceperhour FROM services WHERE services.serviceid = {ServiceId};";
            return query;
        }

        public static string GetPricePerMinute(int ServiceId)
        {
            var query =
            $"SELECT Services.priceperminute FROM services WHERE services.serviceid = {ServiceId};";
            return query;
        }

        public static string GetServiceName(int ServiceId)
        {
            var query =
            $"SELECT Services.name FROM services WHERE services.serviceid = {ServiceId};";
            return query;
        }

        // public static string GetFreeServicesId(int EntranceMethodId)
        // {
        //      Nie wiem jak zrobić
        //}

        public static string GetCustomerId(int WatchId)
        {
            var query =
            $"SELECT Watches.Customerid FROM watches WHERE watches.watchid = {WatchId};";
            return query;
        }

        public static string GetServiceId(int WatchId)
        {
            var query =
            $"SELECT Watches.Serviceid FROM watches WHERE watches.watchid = {WatchId};";
            return query;
        }

        public static string GetDiscountAmount(int DiscountId)
        {
            var query =
            $"SELECT Discounts.amount FROM discounts WHERE discounts.discountid = {DiscountId};";
            return query;
        }

        public static string CreateCharge(int Amount, int WatchId)
        {
            var query =
            $"INSERT INTO CHARGES (Amount, WatchId) VALUES({Amount}, {WatchId});";
            return query;
        }

        public static string GetSumOfWatchCharges(int WatchId)
        {
            var query =
            $"SELECT SUM(Charge.amount) FROM charge Where charge.WatchId = {WatchId};";
            return query;
        }

        public static string GetEntranceTime(int WatchId)
        {
            var query =
            $"SELECT Entrances.TIME FROM Entrances WHERE entrances.Watchid = {WatchId};";
            return query;
        }

        public static string CreateExit(int WatchId, DateTime time)
        {
            var query =
            $"INSERT INTO EXITS (WatchId, Time) VALUES({WatchId}, {time});"; //
            return query;
        }

        public static string GetExitTime(int WatchId)
        {
            var query =
            $"SELECT Exits.TIME FROM Exits WHERE Exits.Watchid = {WatchId};"; 
            return query;
        }

        public static string CreateVisit(int WatchId, int ServiceId, int CustomerId, decimal Amount)
        {
            var query =
            $"INSERT INTO Visits (WatchId, ServiceId, CustomerId, Amount) VALUES({WatchId}, {ServiceId}, {CustomerId}, {Amount});"; 
            return query;
        }

    }
}
