using MailSenderExample.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Campaign
{
    public class CampaignContent : BaseContent
    {
        public Dictionary<int, string> ProductList { get; set; }
        public List<string> CustomerMailList { get; set; }
    }
}
