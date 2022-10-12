using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ReplaceDir();
        }

        static void ReplaceDir()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\Files\test");
            string newPath = @"C:\\Files\Trash\test";

            if(!Directory.Exists(newPath))
            {
                dirInfo.MoveTo(newPath);
            }
        }
    }
}