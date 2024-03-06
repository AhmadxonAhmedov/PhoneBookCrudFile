using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudFile.Broker.Loggins
{
    internal interface ILoggingBroker
    {
        public void LoginInformation(string message);
        public void LogError(Exception message);
        public void LogWarning(string message);
    }
}
