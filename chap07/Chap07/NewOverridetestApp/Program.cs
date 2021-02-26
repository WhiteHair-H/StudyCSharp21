using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverridetestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "성명건", "010-6683-7732", "부산시 해운대구", true);
            var tuple2 = (Idx: 2,Name: "성명건",Phone: "010-6683-7732",Address: "부산시 해운대구", Marrige: false);

            Console.WriteLine($"{tuple1.Item1} / {tuple1.Item2} / {tuple1.Item3} / {tuple1.Item4} / {tuple1.Item5}");
            Console.WriteLine($"{tuple2.Item1} / {tuple2.Item2} / {tuple2.Item3} / {tuple2.Item4} / {tuple2.Item5}");
            Console.WriteLine($"{tuple2.Idx} / {tuple2.Name} / {tuple2.Phone} / {tuple2.Address} / {tuple2.Marrige}");

        }
    }
}
