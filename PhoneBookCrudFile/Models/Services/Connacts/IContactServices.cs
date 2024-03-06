using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudFile.Models.Services.Connacts
{
    internal interface IContactServices
    {
        public Data AddToServices(Data data);
        public void ViewData();
        public void DeleteFromServicesById(int Id);
        public void DeleteToServices(Data data);
        void AddToServices();
    } 
}
