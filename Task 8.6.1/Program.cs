using System;
using System.IO;
namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string FolderName = @"C\\Files\Test";
            clearFolder(FolderName);
        }

        static void clearFolder(string FolderName)
        {
            try
            {
                if (Directory.Exists(FolderName))
                {
                    DirectoryInfo dir = new DirectoryInfo(FolderName);

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
