using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAddress
{
    class GetSelectMenu : Program
    {
        public int GetSelectMenu()
        {
            int sel = -1;
            Console.WriteLine("메뉴를 선택하세요");
            sel = Int32.Parse(Console.ReadLine());
            return sel;
        }
    }
}
