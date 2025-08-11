using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
