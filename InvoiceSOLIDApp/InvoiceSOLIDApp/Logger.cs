using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceSOLIDApp
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
    public class Logger : ILogger
    {
        public Logger()
        {

        }

        public void Info(string info)
        {
            //throw new NotImplementedException();
        }

        public void Debug(string info)
        {
            //throw new NotImplementedException();
        }

        public void Error(string message, Exception ex)
        {
            //throw new NotImplementedException();
        }
    }
}
