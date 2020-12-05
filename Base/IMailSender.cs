using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Base
{
    public interface IMailSender<T,I> where T : IBase where I : IStrategy
    {
        void SendMail();
    }
}
