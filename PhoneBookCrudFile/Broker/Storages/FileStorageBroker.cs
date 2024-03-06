using PhoneBookCrudFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudFile.Broker.Storages;

internal class FileStorageBroker: IFileStorageBroker
{
    private const string FilePath = @"C:\Users\Ahmadxon\Source\Repos\PhoneBookCrudFile\PhoneBookCrudFile\Assed\Files.txt";
    public FileStorageBroker()
    {
        EnsureFileExist();
    }

    public Data AllDataToFiles(Data data)
    {
        string data1 = $"{data.Id}*{data.Name}*{data.PhoneNumber}\n";
        File.AppendAllText(FilePath, data1);
        return data;
    }

    public Data[] ReadAllDataFromFiles() 
    {
        string[] warpdata = File.ReadAllLines(FilePath);
        int datalines = warpdata.Length;

        Data[] data = new Data[datalines];

        for (int i = 0; i < warpdata.Length; i++)
        {
            string datas = warpdata[i];
            string[] splits = datas.Split("*");
            Data data1 = new Data
            {
                Id = Convert.ToInt32(splits[0]),
                Name = splits[1],
                PhoneNumber = splits[2]
            };

            if (data[i] is null)
            {
                data[i] = data1;
            }
        }
        return data;
    }

    //public Data[] RoadAllDataFromFiles() 
    //{
    //    throw new NotImplementedException();
    //}

    private void EnsureFileExist()
    {
        bool exist = File.Exists(FilePath);
        if (!exist)
        {
            File.Create(@"C:\Users\Ahmadxon\Source\Repos\PhoneBookCrudFile\PhoneBookCrudFile\Assed\Files.txt").Close();
        }
    }
}

