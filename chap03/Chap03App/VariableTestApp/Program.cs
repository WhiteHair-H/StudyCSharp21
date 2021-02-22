using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int v1 = 30;
            int v2 = 40;
            int result = v1 + v2;
            Console.WriteLine("결과는 " + result);*/


            sbyte sbMinVal = sbyte.MinValue;
            sbyte sbMaxVal = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소 , 최대값은 {sbMinVal}, {sbMaxVal} 입니다. ");

            byte bminVAl = byte.MinValue;
            byte bmaxVAl = byte.MaxValue;
            Console.WriteLine($"byte 최소 , 최대값은 {bminVAl}, {bmaxVAl} 입니다. ");

            short sminVAl = short.MinValue;
            short smaxVAl = short.MaxValue;
            Console.WriteLine($"short 최소 , 최대값은 {sminVAl}, {smaxVAl} 입니다. ");

            ushort usminVAl = ushort.MinValue;
            ushort usmaxVAl = ushort.MaxValue;
            Console.WriteLine($"ushort 최소 , 최대값은 {usminVAl}, {usmaxVAl} 입니다. ");

            int IminVAl = int.MinValue;
            int ImaxVAl = int.MaxValue;
            Console.WriteLine($"int 최소 , 최대값은 {IminVAl}, {ImaxVAl} 입니다. ");

            uint uiminVAl = uint.MinValue;
            uint uimaxVAl = uint.MaxValue;
            Console.WriteLine($"uint 최소 , 최대값은 {uiminVAl}, {uimaxVAl} 입니다. ");

            long LminVAl = long.MinValue;
            long LmaxVAl = long.MaxValue;
            Console.WriteLine($"long 최소 , 최대값은 {LminVAl}, {LmaxVAl} 입니다. ");

            ulong uLminVAl = ulong.MinValue;
            ulong uLmaxVAl = ulong.MaxValue;
            Console.WriteLine($"ulong 최소 , 최대값은 {uLminVAl}, {uLmaxVAl} 입니다. ");


            float fMinVal = float.MinValue, fMaxVal = float.MaxValue;
            Console.WriteLine($"float 최소 , 최대값은 {fMinVal}, {fMaxVal} 입니다.");

            double dMinVal = float.MinValue, dMaxVal = double.MaxValue;
            Console.WriteLine($"double 최소 , 최대값은 {dMinVal}, {dMaxVal} 입니다.");

            decimal dcMinVal = decimal.MinValue, dcMaxVal = decimal.MaxValue;
            Console.WriteLine($"decimal 최소 , 최대값은 {dcMinVal}, {dcMaxVal} 입니다.");


        }
    }
}
