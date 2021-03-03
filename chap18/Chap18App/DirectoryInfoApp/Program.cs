using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string srtDir;
            srtDir = @"C:\Program Files\Bandizip"; // 폴더 정보 확인

            Console.WriteLine($"{srtDir} 디렉터리 정보");
            /*var directories = (from dir in Directory.GetDirectories(srtDir)
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attribute = info.Attributes
                               }).ToList();*/
            /*foreach (var item in directories)
            {
                Console.WriteLine($"{item.Name} : {item.Attribute}");
            }*/


            var directories = new DirectoryInfo(srtDir).GetDirectories();
            foreach (var item in directories)
            {
                Console.WriteLine($"{item.Name} : {item.Attributes} : {item.Extension}");
            }

            Console.WriteLine($"{srtDir} 파일 정보");
            var files = new DirectoryInfo(srtDir).GetFiles();
            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name} : {item.Attributes} : {Math.Ceiling((double)item.Length / 1024):#,###}KB : {item.Extension}");
            }

        }
    }
}
