using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Base
{
    public interface IProviderStrategy<T> where T : class
    {
        void Send(T mailContent);
    }
}
