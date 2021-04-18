using System;

namespace BillCalculator
{
   public class Invoice : IInvoice
    {
        public decimal MonthlyTax { get; }
        public int SentSMS { get; }
        public int SentMMS { get; }
        public int MinutesToA1OutsidePackage { get; }
        public int MinutesToTelenorOutsidePackage { get; }
        public int MinutesToVivacomOutsidePackage { get; }
        public int MinutesRouming { get; }
        public double UsedMBInBGOutsidePackage { get; }
        public double UsedMBInEuropeOutsidePackage { get; }
        public double UsedMBOutsideEuropeOutsidePackage { get; }
        public decimal AnotherTaxes { get; }
        public double Discount { get; }
        public decimal Result { get; private set; }
        public Invoice(decimal monthlyTax, int sentSMS, int sentMMS, int minutesToA1OutsidePackage, int minutesToTelenorOutsidePackage,
            int minutesToVivacomOutsidePackage, int minutesRouming, double usedMBInBGOutsidePackage, double usedMBInEuropeOutsidePackage,
            double usedMBOutsideEuropeOutsidePackage, decimal anotherTaxes, double discount)
        {
            MonthlyTax = monthlyTax;
            SentSMS = sentSMS;
            SentMMS = sentMMS;
            MinutesToA1OutsidePackage = minutesToA1OutsidePackage;
            MinutesToTelenorOutsidePackage = minutesToTelenorOutsidePackage;
            MinutesToVivacomOutsidePackage = minutesToVivacomOutsidePackage;
            MinutesRouming = minutesRouming;
            UsedMBInBGOutsidePackage = usedMBInBGOutsidePackage;
            UsedMBInEuropeOutsidePackage = usedMBInEuropeOutsidePackage;
            UsedMBOutsideEuropeOutsidePackage = usedMBOutsideEuropeOutsidePackage;
            AnotherTaxes = anotherTaxes;
            Discount = discount;
        }
        public decimal GetCalculatedPrice()
        {
            AddMonthlyTax();
            AddTaxSMS();
            AddTaxMMS();
            AddTaxMinutesOutsidePackage();
            AddTaxUsedMBOutsidePackage();
            AddAnotherTax();
            AddDiscount();
            return Result;
        }
        void AddMonthlyTax()
        {
            Result += MonthlyTax;
        }
        void AddTaxSMS()
        {
            if (SentSMS < 50)
            {
                decimal totalPriceSMS = SentSMS * 0.18m;
                Result += totalPriceSMS;
            }
            else if (SentSMS > 50 && SentSMS < 100)
            {
                decimal totalPriceSMS = SentSMS * 0.16m;
                Result += totalPriceSMS;
            }
            else if (SentSMS > 100)
            {
                decimal totalPriceSMS = SentSMS * 0.11m;
                Result += totalPriceSMS;
            }
        }
        void AddTaxMMS()
        {
            if (SentMMS < 50)
            {
                decimal totalPriceMMS = SentMMS * 0.25m;
                Result += totalPriceMMS;
            }
            else if (SentMMS > 50 && SentMMS < 100)
            {
                decimal totalPriceMMS = SentMMS * 0.23m;
                Result += totalPriceMMS;
            }
            else if (SentMMS > 100)
            {
                decimal totalPriceMMS = SentMMS * 0.18m;
                Result += totalPriceMMS;
            }
        }
         void AddTaxMinutesOutsidePackage()
        {
            decimal totalPriceToA1 = MinutesToA1OutsidePackage * 0.03m;
            decimal totalPriceToTelenor = MinutesToTelenorOutsidePackage * 0.09m;
            decimal totalPriceToVivacom = MinutesToVivacomOutsidePackage * 0.09m;
            decimal totalPriceToRouming = MinutesRouming * 0.15m;

            Result += totalPriceToA1;
            Result += totalPriceToTelenor;
            Result += totalPriceToVivacom;
            Result += totalPriceToRouming;
        }
        void AddTaxUsedMBOutsidePackage()
        {
            decimal totalPriceInBG = Convert.ToDecimal(UsedMBInBGOutsidePackage * 0.02);
            decimal totalPriceInEurope = Convert.ToDecimal(UsedMBInEuropeOutsidePackage * 0.05);
            decimal totalPriceWithinEurope = Convert.ToDecimal(UsedMBOutsideEuropeOutsidePackage * 0.20);

            Result += totalPriceInBG;
            Result += totalPriceInEurope;
            Result += totalPriceWithinEurope;
        }
        void AddAnotherTax()
        {
            Result += AnotherTaxes;
        }
        void AddDiscount()
        {
            Result -= (decimal)Discount;
        }
    }
}