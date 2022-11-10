using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class Notification
    {
        public virtual void SendMessage(string message)
        {
            Console.WriteLine("Notifaction: " + message);
        }
    }
}
