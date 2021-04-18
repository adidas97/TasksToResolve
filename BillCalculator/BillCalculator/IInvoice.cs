using System;
using System.Collections.Generic;
using System.Text;

namespace BillCalculator
{
    interface IInvoice
    {
        decimal GetCalculatedPrice();
    }
}
