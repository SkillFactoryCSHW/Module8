using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDir();
            GetFilesNum();
        }

        static void CreateDir()
        {
            DirectoryInfo newDir = new DirectoryInfo(@"C:\\Files");
            
            if(newDir.Exists)
            {
                newDir.CreateSubdirectory(@"NewDir");

            }
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