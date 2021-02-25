using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08App
{




    interface ILogger
    {
        void writeLog(string msg);
    }


    class ConsoleLogger : ILogger
    {
        public void writeLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now.ToShortDateString()} log : {msg}");
        }
    }


    class ClimatLogger
    {
        private ILogger logger;
        public ClimatLogger(ILogger logger)
        {
            this.logger = logger;

        }

        public void Start()
        {
            while (true)
            {
                Console.Write("온도를 입력 : ");
                string temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp)) break;
                {
                    logger.writeLog($"현재 온도 : {temp}");
                }

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.writeLog("로그출력"); // 직접제어

            ClimatLogger climat = new ClimatLogger(new ConsoleLogger()); // 제어역전
            climat.Start(); // 제어의 역전 : 프레임워크의 특성상 자동으로 생성해줌

        }
    }
}
