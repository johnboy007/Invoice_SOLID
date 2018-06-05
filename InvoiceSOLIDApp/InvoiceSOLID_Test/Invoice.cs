using System;
using InvoiceSOLIDApp;
using NUnit.Framework;

namespace InvoiceSOLID_Test
{
    [TestFixture]
    public class Invoice
    {
        [Test]
        public void CanAddFinalInvoice()
        {
            var finalInvoice = new FinalInvoice();
            Assert.IsNotNull(finalInvoice);
            Assert.Greater(finalInvoice.GetDiscount(200),0);
            finalInvoice.Add();
            finalInvoice.Delete();
        }

        [Test]
        public void CanAddProposedInvoice()
        {
            var proposedInvoice = new ProposedInvoice();
            Assert.IsNotNull(proposedInvoice);
            Assert.Greater(proposedInvoice.GetDiscount(200), 0);
            proposedInvoice.Add();
            proposedInvoice.Delete();
        }
    }
}
