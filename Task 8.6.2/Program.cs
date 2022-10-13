using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C\\Files\Test");
            DirSize(d);
        }
        public static long DirSize(DirectoryInfo d)
        {
            string folder = @"C\\Files\Test";

            try
            {
                if (Directory.Exists(folder))
                {
                    long size = 0;
                    FileInfo[] fis = d.GetFiles();
                    foreach (FileInfo fi in fis)
                    {
                        size += fi.Length;
                    }
                    DirectoryInfo[] dis = d.GetDirectories();
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