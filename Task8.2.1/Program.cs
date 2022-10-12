using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
        static void GetFilesNum()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\");

            if (dirInfo.Exists)
            {
                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
            }
        }
    }
}