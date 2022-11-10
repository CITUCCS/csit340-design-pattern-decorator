using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class FacebookDecorator : BaseDecorator
    {
        public FacebookDecorator(Notification notification) : base(notification)
        {
            _notification = notification;
        }

        public override void SendMessage(string message)
        {
            SendFBMessage(message);
            _notification.SendMessage(message);
        }

        private void SendFBMessage(string message)
        {
            Console.WriteLine("FB Notification: " + message);
        }
    }
}
