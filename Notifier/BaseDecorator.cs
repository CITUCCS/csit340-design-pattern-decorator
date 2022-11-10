using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class BaseDecorator : Notification
    {
        protected Notification _notification;

        public BaseDecorator(Notification notification)
        {
            _notification = notification;
        }

        public override void SendMessage(string message)
        {
            _notification.SendMessage(message);
        }
    }
}
