using MailSenderExample.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Order
{
    public class OrderContent : BaseContent
    {
        public Dictionary<int, string> ProductList { get; set; }
        public string CustomerMail { get; set; }
    }
}
