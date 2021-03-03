using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateChain2
{
    class Program
    {

        delegate void ThereIsFire(string location); // 대리자 선언

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불났으예 주소는 {location}입니다!");

        }

        static void ShotOut(string location)
        {
            Console.WriteLine($"머고 불이가 {location}에 불났으예~");

        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 빨리 나가입시더");

        }


        static void Main(string[] args)
        {
            ThereIsFire fire = new ThereIsFire(ShotOut);
            fire += new ThereIsFire(Call119); //기본문법
            fire += Escape; // 약식문법

            fire("대연동");


        }
    }
}
