using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookApp
{
    class DataFileManager
    {

        const string dataFileName = "address.dat";


        public List<Address> ReadData()
        {

            var listResult = new List<Address>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터 파일


            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            while (sr.EndOfStream == false)
            {

                var temp = sr.ReadLine();
                // temp 잘라서 manager.listAddress 할당
                string[] splits = temp.Split("|");
                listResult.Add(new Address() { name = splits[0], phone = splits[1], address = splits[2] });

            }
            sr.Close();

            return listResult;
        }


        public void WriteData(List<Address> param)
        {
            string filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터 파일

            StreamWriter sw = new StreamWriter(
                            new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));

            if (param.Count > 0)
            {
                foreach (var item in param)
                {
                    sw.WriteLine($"{item.name}|{item.phone}|{item.address}");
                }
            }

            sw.Close();
        }


    }
}
