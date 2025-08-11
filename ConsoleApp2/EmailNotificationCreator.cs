using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification() => new EmailNotification();
    }

    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification() => new SmsNotification();
    }
}
