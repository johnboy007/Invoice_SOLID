using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceSOLIDApp
{
   public class FinalInvoice : Invoice, IInvoice
    {
        public FinalInvoice()
        {
          //  _invoice = new Invoice();
        }
        

        public double GetDiscount(double amount)
        {
            return amount * 0.3;
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
