using MailSenderExample.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.EmailerStrategy
{
    public class APIProvider<T> : IProviderStrategy<T> where T : BaseContent
    {
        public void Send(T mailContent)
        {
            // set config then send email
            Console.WriteLine("Mail sent by API provider !");
        }
    }
}
