using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFilesNum();
        }
        
        static void GetFilesNum()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\Files");

            if (dirInfo.Exists)
            {
                Console.WriteLine(dirInfo.GetDirectories().Length);
            }
        }
    }
}