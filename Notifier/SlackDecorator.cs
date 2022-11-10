using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notification notification) : base(notification)
        {
            _notification = notification;
        }

        public override void SendMessage(string message)
        {
            SendSlackMessage(message);
            _notification.SendMessage(message);
        }

        private void SendSlackMessage(string message)
        {
            Console.WriteLine("Slack Notification: " + message);
        }
    }
}
