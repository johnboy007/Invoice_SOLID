using System;
using System.Net.Mail;

namespace InvoiceSOLIDApp {

    public interface IInvoice
    {
       double GetDiscount(double amount);
    }
}
