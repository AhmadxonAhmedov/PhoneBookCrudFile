using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudFile.Broker.Loggins
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void LogError(Exception message)
        {
            Console.WriteLine(message);
        }

        public void LoginInformation(string message)
        {
           Console.WriteLine(message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine(message);
        }
    }
}
