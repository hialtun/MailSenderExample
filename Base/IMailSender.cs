using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Base
{
    public interface IMailSender<T> where T : class
    {
        void SendMail();
    }
}
