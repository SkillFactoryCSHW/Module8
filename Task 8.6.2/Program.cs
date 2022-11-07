using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C\\Files\Test");
            DirSize(dir);
        }
        public static long DirSize(DirectoryInfo dir)
        {
            string folder = @"C\\Files\Test";

            try
            {
                if (Directory.Exists(folder))
                {
                    long size = 0;
                    FileInfo[] fis = dir.GetFiles();
                    foreach (FileInfo fi in fis)
                    {
                        size += fi.Length;
                    }
                    DirectoryInfo[] dis = dir.GetDirectories();
                    foreach (DirectoryInfo di in dis)
                    {
                        size += DirSize(di);
                    }
                    return size;
                }
                else
                {
                    return 0;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
                return 0;
            }
        }
    }
}