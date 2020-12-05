using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Base
{
    public class BaseContent : IBase
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string To { get; set; }
    }
}
