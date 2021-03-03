using System;
using System.IO;

namespace GenDirFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = "D:\\GitRepository\\StudyCSharp21\\SampleDir";
            string strtargetDir = "subFolder";
            string strTargetFile = "readme.txt";


            string targetPath = strDir + "\\" +strtargetDir; // "\\" 파일 조심하기

            if (Directory.Exists(strtargetDir))
            {
                Console.WriteLine("이미 폴더가 진행합니다.");
            }
            else
            {
                Directory.CreateDirectory(targetPath);
                Console.WriteLine("폴더 생성 성공");
            }



            targetPath += $"\\{strTargetFile}";
            if (File.Exists(targetPath))
            {
                Console.WriteLine("파일이 존재합니다.");
            }
            else
            {
                File.Create(targetPath).Close();
                Console.WriteLine("파일 생성 성공");

            }

        }
    }
}
