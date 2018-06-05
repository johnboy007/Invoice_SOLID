using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceSOLIDApp
{
   public class ProposedInvoice : Invoice, IInvoice
    {
        public ProposedInvoice()
        {
        }
        

        public double GetDiscount(double amount)
        {
            return amount * 0.5;
        }

        public void Add()
        {
            base.Add();
        }

        public void Delete()
        {
            base.Delete();
        }
    }
}
