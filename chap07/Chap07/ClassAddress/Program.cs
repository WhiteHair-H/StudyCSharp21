using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAddress
{
    class Program : Address
    {
        public int num;


       static List<Address> addresses = new List<Address>();

        static void MainLoop()
        {
            while (true)
            {
                ClearView();
                PrintMenu menu = new PrintMenu();
                

                GetSelectMenu getSelectMenu = new GetSelectMenu();
                int sel = getSelectMenu

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
