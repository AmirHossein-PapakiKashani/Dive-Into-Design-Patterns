using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void Send(string message)
        {
            var notification = CreateNotification();
            notification.Notify(message);
        }
    }
}
