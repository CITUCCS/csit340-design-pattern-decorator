using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(Notification notification) : base(notification)
        {
            _notification = notification;
        }

        public override void SendMessage(string message)
        {
            SendSmsMessage(message);
            _notification.SendMessage(message);
        }

        private void SendSmsMessage(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }
}
