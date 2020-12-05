using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Base
{
    public abstract class MailSenderTemplate<T, I> : IMailSender<T, I> where T : BaseContent where I : IProviderStrategy<T>
    {
        protected T _mailContent;
        protected I _provider;

        public MailSenderTemplate(T mailContent)
        {
            _mailContent = mailContent;
        }
        protected abstract void SetSubject();
        protected abstract void SetToAddress();
        protected abstract void SetBody();
        protected abstract void SetProvider();

        public void SendMail()
        {
            SetSubject();
            SetToAddress();
            SetBody();
            SetProvider();
            _provider.Send(_mailContent);
        }
    }
}
