using System.ComponentModel.DataAnnotations;

namespace WorkingWithCSVFile
{
    public class Offer
    {
        public Offer(double monthlyFee, int newContractsForMonth, int sameContractsForMonth, int cancelledContractsForMonth)
        {
            MonthlyFee = monthlyFee;
            NewContractsForMonth = newContractsForMonth;
            SameContractsForMonth = sameContractsForMonth;
            CancelledContractsForMonth = cancelledContractsForMonth;
        }
        [Key]
        public int OfferId { get; set; }
        public double MonthlyFee { get; set; }
        public int NewContractsForMonth { get; set; }
        public int SameContractsForMonth { get; set; }
        public int CancelledContractsForMonth { get; set; }
    }
}