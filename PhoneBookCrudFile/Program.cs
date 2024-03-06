using PhoneBookCrudFile.Models;
using PhoneBookCrudFile.Models.Services.Connacts;

namespace PhoneBookCrudFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContactServices broker = new ContactServices();
            Data data = new Data()
            {
                Id = 1,
                Name = "Test",
                PhoneNumber = "1234567"              
            };
            broker.AddToServices(data);
            broker.ViewData();
            broker.AddToServices();
        }
    }
}
