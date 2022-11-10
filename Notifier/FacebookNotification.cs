using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class FacebookNotification : Notification
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("FB Notification: " + message);
        }
    }
}
