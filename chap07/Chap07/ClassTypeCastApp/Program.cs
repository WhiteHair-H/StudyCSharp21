using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다!");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class 고양이 : 포유류
    {
        public void 냥냥()
        {
            Console.WriteLine("냐옹!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            _포유류 = new 강아지(); // 자식이 부모에게 들어갈 수있음
            _포유류.키우다();
            //-포유류.멍멍(); // 에러
            강아지 쭈쭈;


            if (_포유류 is 강아지) { }
            {
                쭈쭈 = _포유류 as 강아지;
                쭈쭈.멍멍();
            }




            /*_포유류 = new 고양이(); // 묵시적
            _포유류.키우다();
            //-포유류.냥냥(); // 에러*/


            //강아지 뽀삐 = (강아지) new 포유류(); // 형변환 : 자식에게 부모를 넣는 것은 불가능하지만 (강아지)를 넣을 경우 가능하지만 코드상 문제는 없지만 실행에 문제가 생김
            강아지 뽀삐 = null;
            if (뽀삐 is 포유류)
            {
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            } // 포유류가 부모이기에 자식 기능을 사용하지 못함

            /*고양이 로미 = (고양이) new 포유류(); // 명시적
            로미.키우다();
            로미.냥냥();*/
        }
    }
}
