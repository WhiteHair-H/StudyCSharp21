using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Address
    {
        public string name;
        public string phone;
        public string address;
    }


    class Program
    {
        static List<Address> arrayAddress = new List<Address>();

        static void MainLoop()
        {
            while (true)
            {
                ClearView();
                PrintMenu();
                int sel = GetSelectMenu();

                switch (sel)
                {
                    case 0:
                        InputAddress();
                        break;
                    case 1:
                        Searchaddress();
                        break;
                    case 2:
                        UpdateAddress();
                        break;
                    case 3:
                        DeleteAddress();
                        break;
                    case 4:
                        PrintAllAddress();
                        break;
                    case 5:
                        ProgramExit();
                        break;
                    default:
                        Console.WriteLine("잘못 입력했다이");
                        break;

                }


            }
        }



       static void PrintMenu()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체 출력");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("----------------");

        }

        static int GetSelectMenu()
        {
            int sel = -1;
            Console.WriteLine("메뉴를 선택하세요");
            sel = Int32.Parse(Console.ReadLine());
            return sel;
        }

        static void InputAddress()
        {
            ClearView();
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("번호 입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();
            Address addr = new Address();
            addr.name = name;
            addr.phone = phone;
            addr.address = address;
            arrayAddress.Add(addr);
        }


        static void Searchaddress()
        {
            ClearView();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();

            for (int i = 0; i < arrayAddress.Count; i++)
            {
                if (name == arrayAddress[i].name)
                {
                    Console.WriteLine($"------{i}--------");
                    Console.WriteLine($"이름 : {arrayAddress[i].name}");
                    Console.WriteLine($"번호 : {arrayAddress[i].phone}");
                    Console.WriteLine($"주소 : {arrayAddress[i].address}");
                    Console.WriteLine($"--------------");
            break;
                }
            }
            Console.ReadKey();

        }

        static void UpdateAddress()
        {
            ClearView();
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();

            for (int i = 0; i < arrayAddress.Count; i++)
            {
                if (name == arrayAddress[i].name)
                {
                    Console.WriteLine($"------{i}--------");
                    Console.WriteLine($"이름 : {arrayAddress[i].name}");
                    Console.WriteLine($"번호 : {arrayAddress[i].phone}");
                    Console.WriteLine($"주소 : {arrayAddress[i].address}");
                    Console.WriteLine($"------{i}--------");
                    Console.Write("이름 입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write("번호 입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("주소 입력 : ");
                    string uAddress = Console.ReadLine();
                    arrayAddress[i].name = uName;
                    arrayAddress[i].phone = uPhone;
                    arrayAddress[i].address = uAddress;
                    break;
                }
            }
            Console.ReadKey();
        }

        static void DeleteAddress()
        {
            ClearView();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();

            for (int i = 0; i < arrayAddress.Count; i++)
            {
                if (name == arrayAddress[i].name)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine($"이름 : {arrayAddress[i].name}");
                    Console.WriteLine($"번호 : {arrayAddress[i].phone}");
                    Console.WriteLine($"주소 : {arrayAddress[i].address}");
                    Console.WriteLine("----------------");
                    Console.Write("진짜 지울기가? [y/n]");
                    string yesorno = Console.ReadLine();
                    if (yesorno == "y")
                    {
                        arrayAddress.RemoveAt(i);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }

        static void PrintAllAddress()
        {
            for (int i = 0; i < arrayAddress.Count; i++)
            {
                Console.WriteLine($"------{i}--------");
                Console.WriteLine($"이름 : + {arrayAddress[i].name}");
                Console.WriteLine($"번호 : + {arrayAddress[i].phone}");
                Console.WriteLine($"주소 : + {arrayAddress[i].address}");
                Console.WriteLine("------------------");
            }
            Console.ReadKey();
        }




        static void ClearView()
        {
            Console.Clear();
        }

        static void ProgramExit()
        {
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
