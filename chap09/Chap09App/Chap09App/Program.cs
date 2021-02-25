using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09App
{

    class MyClass
    {
        private int ivalue; //  0 ~ 120℃ 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int incode;


        public int IValue { 
            get { 
                return this.ivalue; 
                } 

            set {
                if (value < 0)
                {
                    this.ivalue = 0;
                }
                else if (value > 120)
                {
                    this.ivalue = 120;
                }
                else
                {
                    this.ivalue = value;
                }
            }                    
        }

        public MyClass(int value)
        {
            IValue = ivalue;

        }



        /*public int GetValue()
        {
            return this.value;
        }


        public void SetValue(int value)
        {
            if (value < 0)
            {
                this.value = 0;
            }
            else if (value > 120)
            {
                this.value = 120;
            }
            else
            {
                this.value = value;
            }



            
        }*/


        public void PrintValue()
        {
            Console.WriteLine($"값은 {IValue}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1200);
            myClass.PrintValue();



            //myClass.SetValue(2345);
            myClass.IValue = -108;
            myClass.PrintValue();
            //Console.WriteLine($"현재 온도는 {myClass.GetValue()} 입니다.");
            Console.WriteLine($"현재 온도는 {myClass.IValue}℃ 입니다.");
        }
    }
}
