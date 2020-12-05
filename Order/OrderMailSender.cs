using MailSenderExample.Base;
using MailSenderExample.EmailerStrategy;
using System;

namespace MailSenderExample.Order
{
    public class OrderMailSender : MailSenderTemplate<OrderContent, APIProvider<OrderContent>>
    {
        public OrderMailSender(OrderContent orderContent) : base(orderContent) {}

        protected override void SetBody()
        {
            _mailContent.Body = "Orders";
            foreach (var item in _mailContent.ProductList)
            {
                _mailContent.Body += "Product: " + item.Value + " Price: " + item.Key.ToString() + " ";
            }
            Console.WriteLine(_mailContent.Body);
        }

        protected override void SetProvider()
        {
            _provider = new APIProvider<OrderContent>();
        }

        protected override void SetSubject()
        {
            Console.WriteLine(_mailContent.Subject);
        }

        protected override void SetToAddress()
        {
            _mailContent.To += _mailContent.CustomerMail;
            Console.WriteLine(_mailContent.To);
        }
    }
}
