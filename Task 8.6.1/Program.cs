using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"C\\Files\Test";
            clearFolder(folderName);
        }

        static void clearFolder(string folderName)
        {
            try
            {
                if (Directory.Exists(folderName))
                {
                    DirectoryInfo dir = new DirectoryInfo(folderName);

                    foreach (FileInfo fi in dir.GetFiles())
                    {
                        fi.Delete();
                    }

                    foreach (DirectoryInfo di in dir.GetDirectories())
                    {
                        clearFolder(di.FullName);
                        di.Delete();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
        }
    }
}
