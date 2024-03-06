using PhoneBookCrudFile.Broker.Loggins;
using PhoneBookCrudFile.Broker.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudFile.Models.Services.Connacts
{
    internal class ContactServices : IContactServices
    {
        IFileStorageBroker fileStorageBroker;
        ILoggingBroker loggingBroker;
        private int id;

        public ContactServices()
        {
            fileStorageBroker = new FileStorageBroker();
            loggingBroker = new LoggingBroker();
        }
        public void ViewData()
        {
            Data[] data = this.fileStorageBroker.ReadAllDataFromFiles();

            for (int i = 0; i < data.Length; i++)
            {
                this.loggingBroker.LoginInformation($"{data[i].Id} {data[i].Name} {data[i].PhoneNumber}");
            }

            this.loggingBroker.LoginInformation("Datas end");
        }

        public Data AddToServices(Data data)
        {
            if( data == null)
            {
                this.loggingBroker.LogWarning("Data empty");
            }
            else
            {
                fileStorageBroker.AllDataToFiles(data);
            }
            return data;
        }

        public void DeleteFromServicesById(Data data)
        {
            string[] warpdata = File.ReadAllLines(@"C: \Users\Ahmadxon\Source\Repos\PhoneBookCrudFile\PhoneBookCrudFile\Assed\Files.txt");
            int dataline = warpdata.Length;

            Data[] data1 = new Data[dataline];

         for(int i = 0; i < warpdata.Length; i++)
            {
                string datas = warpdata[i];
                string[] splits = datas.Split("*");
                Data data2 = new Data()
                {
                    Id = Convert.ToInt32(splits[0]),
                    Name = splits[1],
                    PhoneNumber = splits[2]
                };

                if (data1[i] is null)
                {
                    data1[i] = data2;
                }
            }

         for(int i = 0;i < data1.Length;i++)
            {
                if (data1[i].Id == id)
                {
                    data1[i] = null;
                }
            }

        }

        public void DeleteFromServicesById(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteToServices(Data data)
        {
            data = null;
        }

        
    }        
}
