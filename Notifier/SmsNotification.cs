using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class SmsNotification : Notification
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }
}
