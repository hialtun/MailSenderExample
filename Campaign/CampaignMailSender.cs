using MailSenderExample.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSenderExample.Campaign
{
    public class CampaignMailSender : MailSenderTemplate<CampaignContent>
    {
        public CampaignMailSender(CampaignContent campaignContent) : base(campaignContent) {}

        protected override void SetBody()
        {
            foreach (var item in _mailContent.ProductList)
            {
                _mailContent.Body += "Product: " + item.Value + " Price: " + item.Key.ToString() + " ";
            }
            Console.WriteLine(_mailContent.Body);
        }

        protected override void SetSubject()
        {
            _mailContent.Subject = "Campaigns For You";
            Console.WriteLine(_mailContent.Subject);
        }

        protected override void SetToAddress()
        {
            foreach (string mail in _mailContent.CustomerMailList)
            {
                _mailContent.To += mail + ";";
            }
            Console.WriteLine(_mailContent.To);
        }
    }
}
