using System;
using System.Linq;

namespace WorkingWithCSVFile
{
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
               CreateDatabase();

               Console.WriteLine("The Database was created successful using Entity Framework Core! You can check it in your MS SQL Server Studio.");
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void CreateDatabase()
        {
            // Creating DbContext and create the database if not exist, else thorw exception that is already exist
            var db = new OffersDbContext();

            if (!db.Database.EnsureCreated())
            {
                throw new ArgumentException("Database already exist!");
            }

            // We use our helper class ProcessInput to read from our csv file the values of each row.
            var valueRows = ProcessInput.ReadRowsValue();

            // When we get the collection of all rows, we loop it
            foreach (var row in valueRows)
            {
                // We extract the information from every row which is separated with ';' and then we create an instance
                // with the current data and add the object to the DbSet Offers, finally saving changes.
                var rowData = row.Split(';').ToList();
                double monthlyFee = double.Parse(rowData[1]);
                int newContractsForMonth = int.Parse(rowData[2]);
                int sameContractsForMonth = int.Parse(rowData[3]);
                int cancelledContractsForMonth = int.Parse(rowData[4]);

                var offer = new Offer(monthlyFee, newContractsForMonth, sameContractsForMonth, cancelledContractsForMonth);
                db.Offers.Add(offer);
            }
            db.SaveChanges();
        }
    }
}