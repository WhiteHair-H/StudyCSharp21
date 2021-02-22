using System;

namespace IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int값은 {inCastVal}");


            inCastVal += 5; // 32767 + 5 32772
            short shCastVal = (short)inCastVal;
            Console.WriteLine($"int값 변환한 short값은 {shCastVal}"); // overflow


            float flVal = 3.141592F; // f or F 써야함 float 사용시
            inCastVal = (int)flVal;
            Console.WriteLine($"float값 변환한 int값은 {inCastVal}"); // overflow

            double dlVal = inCastVal;
            Console.WriteLine($"int값 변환한 double값은 {dlVal}"); // overflow

            object obj = 20; // boxing
            int inUnboxingVal = (int)obj; // unboxing
            Console.WriteLine($"object값 변환한 int값은 {inUnboxingVal}"); // overflow

            string strVal = "200";
            int result = int.Parse(strVal) * 3; //문자열을 숫자로 형변환
            Console.WriteLine($"200 * 3 = {result}");
        }

    }
}
