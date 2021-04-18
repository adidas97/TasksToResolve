using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace WorkingWithCSVFile
{
   public static class ProcessInput
    {
        // This is the path where our file exist and the program will get it from there
        // You can change the path to your location
        static readonly string  path = ConfigurationManager.AppSettings.Get("PathToCSVFile");
        private static List<string> ReadColumName()
        {
            // We read all lines of our file and then take the first row which is our colum names and finally return collection
            string[] lines = System.IO.File.ReadAllLines(path);
            var columNames = lines[0].Split(';').ToList();
            return columNames;
        }
        public static List<string> ReadRowsValue()
        {
            // We read all value rows, skipping the first which is colum name and finally return collection
            string[] lines = System.IO.File.ReadAllLines(path);

            var rowsValue = lines.Skip(1).ToList();
            return rowsValue;
        }
        public static string GetOfferId()
        {
            // We invoke our method which give to us the collection of colum names and then we return the OfferId
            var columNames = ReadColumName();
            string offerId = columNames[0];
            return offerId;
        }
        public static string GetMonthlyFee()
        {
            // We invoke our method which give to us the collection of colum names and then we return the MonthlyFee
            var columNames = ReadColumName();
            string monthlyFee = columNames[1];
            return monthlyFee;
        }
        public static string GetNewContractsForMonth()
        {
            // We invoke our method which give to us the collection of colum names and then we return the NewContractsForMonth
            var columNames = ReadColumName();
            string newContractsForMonth = columNames[2];
            return newContractsForMonth;
        }
        public static string GetSameContractsForMonth()
        {
            // We invoke our method which give to us the collection of colum names and then we return the SameContractsForMonth
            var columNames = ReadColumName();
            string sameContractsForMonth = columNames[3];
            return sameContractsForMonth;
        }
        public static string GetCancelledContractsForMonth()
        {
            // We invoke our method which give to us the collection of colum names and then we return the CancelledContractsForMonth
            var columNames = ReadColumName();
            string cancelledContractsForMonth = columNames[4];
            return cancelledContractsForMonth;
        }
    }
}