using System;

namespace BillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monthly Tax:");
            decimal monthlyTax = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Sent SMS:");
            int sentSMS = int.Parse(Console.ReadLine());

            Console.WriteLine("Sent MMS:");
            int sentMMS = int.Parse(Console.ReadLine());

            Console.WriteLine("Minutes to A1 out of package:");
            int minutesToA1OutsidePackage = int.Parse(Console.ReadLine());

            Console.WriteLine("Minutes to telenor out of package:");
            int minutesToTelenorOutsidePackage = int.Parse(Console.ReadLine());

            Console.WriteLine("Minutes to vivacom out of package:");
            int minutesToVivacomOutsidePackage = int.Parse(Console.ReadLine());

            Console.WriteLine("Minutes rouming:");
            int minutesRouming = int.Parse(Console.ReadLine());

            Console.WriteLine("Used MB in Bulgaria out of package:");
            int usedMBInBGOutsidePackage = int.Parse(Console.ReadLine());

            Console.WriteLine("Used MB In Europe out of package:");
            int usedMBInEuropeOutsidePackage = int.Parse(Console.ReadLine());

            Console.WriteLine("Used MB out of Europe out of package:");
            int usedMBOutsideEuropeOutsidePackage = int.Parse(Console.ReadLine());

            Console.WriteLine("Another taxes:");
            decimal anotherTaxes = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Discount:");
            double discount = double.Parse(Console.ReadLine());

            Invoice invoice = new Invoice(monthlyTax,sentSMS,sentMMS,minutesToA1OutsidePackage,minutesToTelenorOutsidePackage,
                minutesToVivacomOutsidePackage,minutesRouming,usedMBInBGOutsidePackage,usedMBInEuropeOutsidePackage,
                usedMBOutsideEuropeOutsidePackage, anotherTaxes,discount);

            decimal resultPrice = invoice.GetCalculatedPrice();

            Console.WriteLine($"The final price is {resultPrice:f2} lv.");
        }
    }
}