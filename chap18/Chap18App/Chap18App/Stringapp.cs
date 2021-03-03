using System;

namespace Chap18App
{
    class Stringapp
    {
        string temp2 = "Global variable String";

        static void Main(string[] args)
        {
            Console.WriteLine("문자열연습 시작");

            // 기본선언
            string message1 = null;
            Console.WriteLine($"{message1}");
            string message2 = string.Empty ;
            Console.WriteLine($"{message2}");
            string oldPath = "C:\\Program Files\\Bandizip";
            string newPath = @"C:\Program Files\Bandizip";

            string greeting = "Hello World";
            var temp1 = "Local Variable String";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine($"{hello}");

            string s1 = "Hello ";
            string s2 = "World ";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = "Hello ";
            string s4 = s3;
            s3 += "World! ";
            Console.WriteLine($"{s4}");


            string row = "Row1\r\nRow2\r\nRow3";
            Console.WriteLine(row);

            Console.WriteLine("---");
            string row2 = "Row1\nRow2\nRow3";
            Console.WriteLine(row2);

            string oldline = "Test " +
                "Test2" +
                "Test3";

            string multiline = @"New Test";
            
            Console.WriteLine();
            Console.WriteLine(oldline);
            Console.WriteLine();
            Console.WriteLine(multiline);


            var book = (lastName: "박", firstName: "상현", title: "이것이 C#이다", 
                company: "한빛미디어" , releaseDate : "2018-07-01", price : 300000 , page : 812);
            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releaseDate).ToShortDateString()} 출간, 페이지수{book.page}, 금액 : {book.price}");



            Console.WriteLine("문자열 조작(함수사용)");
            string s5 = "Visual c# Express";
            Console.WriteLine(s5);
            Console.WriteLine(s5.Trim());
            var s6 = s5.Trim();

            Console.WriteLine(s6.Substring(7));
            Console.WriteLine(s6.Substring(7,2));

            Console.WriteLine(s6.Replace("c#", "Basic"));

            Console.WriteLine(s6.IndexOf("c#"));
            Console.WriteLine(s6.Length);
            Console.WriteLine(s6.ToLower());
            Console.WriteLine(s6.ToUpper());

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr);
            Console.WriteLine(nullstr.Length);
            



        }
    }
}
