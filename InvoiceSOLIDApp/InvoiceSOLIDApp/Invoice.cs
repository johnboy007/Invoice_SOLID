using System;
using System.Net.Mail;

namespace InvoiceSOLIDApp {
    
    public class Invoice
    {
        public long Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        private readonly Logger _logger;
        private readonly MailSender _mailSender;

        protected Invoice()
        {
            _logger = new Logger();
            _mailSender = new MailSender();
        }

        protected void Add()
        {
            try
            {
                _logger.Info("Add method Start");
                // Code for adding invoice
                // Once Invoice has been added , send mail 
                _mailSender.From = "rakesh.girase@thedigitalgroup.net";
                _mailSender.To = "customers@digitalgroup.com";
                _mailSender.Subject = "TestMail";
                _mailSender.Body = "This is a text mail";
                _mailSender.SendEmail();
            }
            catch (Exception ex)
            {
                _logger.Error("Error while Adding Invoice", ex);
            }
        }

        protected void Delete()
        {
            try
            {
                _logger.Info("Add Delete Start");
                // Code for Delete invoice
            }
            catch (Exception ex)
            {
                _logger.Error("Error while Deleting Invoice", ex);
            }
        }
    }
}
