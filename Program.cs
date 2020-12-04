using MailSenderExample.Base;
using MailSenderExample.Campaign;
using MailSenderExample.Order;
using System;
using System.Collections.Generic;

namespace MailSenderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var CampaignContent = new CampaignContent();
            CampaignContent.CustomerMailList = new List<string>() { "customer1@mail.com", "customer2@mail.com" };
            CampaignContent.ProductList = new Dictionary<int, string>() { { 20, "Product A" }, { 30, "Product B" } };
            var campaignMailSender = new CampaignMailSender(CampaignContent);
            campaignMailSender.SendMail();

            var OrderContent = new OrderContent();
            OrderContent.CustomerMail = "customer@mail.com";
            OrderContent.ProductList = new Dictionary<int, string>() { { 20, "Product A" }, { 30, "Product B" } };
            var orderMailSender = new OrderMailSender(OrderContent);
            orderMailSender.SendMail();
        }
    }
}
