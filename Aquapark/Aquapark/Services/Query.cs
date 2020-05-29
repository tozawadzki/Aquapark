﻿using System;

namespace Aquapark.Services
{
    public class Query
    {
        public static string GetGustomers =
            "SELECT * FROM Customers ORDER BY Id";

        public static string GetTransactions =
            "SELECT * FROM Transactions ORDER BY Id";

        public static string GetEntrances =
            "SELECT * FROM Entrances ORDER BY Id";

        public static string GetEntranceMethods =
            "SELECT * FROM EntranceMethod ORDER BY Id";

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
            $"SELECT Discounts.Amount FROM Discounts WHERE Discounts.Id = ({customerId})";
            return query;
        }

        public static string GetTransactionType(int TransactionTypeId)
        {
            var query =
            $"SELECT TransactionType.name FROM transactiontype WHERE transactiontype.id = {TransactionTypeId}";
            return query;
        }

        public static string CreateTransaction(int Id, int ServiceId, int WatchId, int TransactionTypeId, string time)
        {
            var query =
            $"INSERT INTO TRANSACTION (Id, Serviceid, TransactionTypeId, time) VALUES({Id}, {ServiceId}, {WatchId}, {TransactionTypeId}, '{time}'";
            return query;
        }

        public static string GetListOfTransactions(int watchId)
        {
            var query =
            $"SELECT * FROM transaction WHERE watchid = {watchId}";
            return query;
        }

        public static string DeleteTransactions(int watchId)
        {
            var query =
            $"DELETE * FROM transaction WHERE watchid = {watchId}";
            return query;
        }

        public static string GetPricePerHour(int serviceId)
        {
            var query =
            $"SELECT Services.PricePerHour FROM Services WHERE Services.Id = {serviceId}";
            return query;
        }

        public static string GetPricePerMinute(int serviceId)
        {
            var query =
            $"SELECT Services.PricePerMinute FROM Services WHERE Services.Id = {serviceId}";
            return query;
        }

        public static string GetServiceName(int serviceId)
        {
            var query =
            $"SELECT Services.Name FROM Services WHERE Services.Id = {serviceId}";
            return query;
        }

        // public static string GetFreeServicesId(int EntranceMethodId)
        // {
        //      Nie wiem jak zrobić
        //}

        public static string GetCustomerId(int watchId)
        {
            var query =
            $"SELECT Watches.CustomerId FROM Watches WHERE Watches.Id = {watchId}";
            return query;
        }

        public static string GetServiceId(int watchId)
        {
            var query =
            $"SELECT Watches.ServiceId FROM Watches WHERE Watches.Id = {watchId}";
            return query;
        }

        public static string GetDiscountAmount(int discountId)
        {
            var query =
            $"SELECT Discounts.Amount FROM Discounts WHERE Discounts.Id = {discountId}";
            return query;
        }

        public static string CreateCharge(int chargeId, int amount, int watchId)
        {
            var query =
            $"INSERT INTO CHARGES (Id, Amount, WatchId) VALUES({chargeId}, {amount}, {watchId})";
            return query;
        }

        public static string GetSumOfWatchCharges(int watchId)
        {
            var query =
            $"SELECT SUM(Charge.amount) FROM charge Where charge.WatchId = {watchId}";
            return query;
        }

        public static string GetEntranceTime(int watchId)
        {
            var query =
            $"SELECT Entrances.TIME FROM Entrances WHERE entrances.WatchId = {watchId}";
            return query;
        }

        public static string CreateExit(int exitId, int watchId, string time)
        {
            var query =
            $"INSERT INTO EXITS (Id, WatchId, Time) VALUES({exitId}, {watchId}, '{time}')"; 
            return query;
        }

        public static string GetExitTime(int watchId)
        {
            var query =
            $"SELECT Exits.TIME FROM Exits WHERE Exits.WatchId = {watchId}";
            return query;
        }

        public static string CreateVisit(int visitId, int watchId, int serviceId, int customerId, decimal exitPayment)
        {
            var query =
            $"INSERT INTO Visits (Id, WatchId, ServiceId, CustomerId, ExitPayment) VALUES({visitId}, {watchId}, {serviceId}, {customerId}, {exitPayment})";
            return query;
        }

        public static string GetAllCharges(int watchId)
        {
            var query = $"SELECT SUM(Amount) FROM Charges WHERE Charges.WatchId = {watchId}";
            return query;
        }

    }
}
