using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Base
{
    public abstract class MailSenderTemplate<T> : IMailSender<T> where T : BaseContent
    {
        protected T _mailContent;
        public MailSenderTemplate(T mailContent)
        {
            _mailContent = mailContent;
        }
        protected abstract void SetSubject();
        protected abstract void SetToAddress();
        protected abstract void SetBody();

        public void SendMail()
        {
            SetSubject();
            SetToAddress();
            SetBody();
            // Set SMTP or API config then send mail
        }
    }
}
