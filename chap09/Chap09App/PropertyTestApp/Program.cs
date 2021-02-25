using System;

namespace PropertyTestApp
{
    //생일 정보 클래스
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value; // string 타입의 value
            }
        }

        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                this.birthday = value; // datetime 타입의 value
            }
        }



        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반 getset 사용");
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("하진우");
            info.SetBirthday(new DateTime(1990, 1, 8));


            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthday()}\n");

            Console.WriteLine("프로포티 사용");
            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "진우이";
            info2.Birthday = new DateTime(1996, 1, 11);

            Console.WriteLine($"이름 : {info2.Name}");
            Console.WriteLine($"생일 : {info2.Birthday}");


        }
    }
}
