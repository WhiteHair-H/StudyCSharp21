using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    


    class Address
    {
        public string name;
        public string phone;
        public string address;
    }

    class Program
    {
         
        static void MainLoop()
        {
            try
            {
                AddressManager manager = new AddressManager
                {
                    arrayAddress = new List<Address>()
                };

                DataFileManager fileManager = new DataFileManager();
                manager.arrayAddress = fileManager.ReadData();


                // 텍스트 파일에서 저장된 주소록을 불러온다
                while (true)
                {
                    ClearView();
                    Console.WriteLine(Environment.CurrentDirectory);

                    manager.PrintMenu();
                    int sel = manager.GetSelectMenu();

                    switch (sel)
                    {
                        case 0:
                            manager.InputAddress();
                            break;
                        case 1:
                            manager.SerachAddress();
                            break;
                        case 2:
                            manager.UpdateAddress();
                            break;
                        case 3:
                            manager.DeleteAddress();
                            break;
                        case 4:
                            manager.PrintAllAddress();
                            break;
                        case 5:
                            fileManager.WriteData(manager.arrayAddress);
                            ProgramExit();
                            break;

                        default:
                            Console.WriteLine("잘못 입력~");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            
        }

        static void ProgramExit()
        {
            Environment.Exit(0);
        }

        static void ClearView()
        {
            Console.Clear();
        }

        static void Main(string[] args)
        {
            MainLoop();
        }


    }
}