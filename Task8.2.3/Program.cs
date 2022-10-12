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
            DeleteDir();
            GetFilesNum();
        }

        static void CreateDir()
        {
            //DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\Files");



            DirectoryInfo newDir = new DirectoryInfo(@"C:\\Files");

            if (newDir.Exists)
            {
                newDir.CreateSubdirectory(@"NewDir");
                Console.WriteLine("Dirrectory create");

            }
        }

        static void DeleteDir()
        {
            DirectoryInfo delDir = new DirectoryInfo(@"C:\\Files\NewDir");

            if (delDir.Exists)
            {
                delDir.Delete(true);
                Console.WriteLine("Dirrectory delite");
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