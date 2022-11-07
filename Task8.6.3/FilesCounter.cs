using System;
using System.IO;

class FilesCounter
{
    private string path;
    DirectoryInfo dir;
    int count;

    public FilesCounter(string path)
    {
        this.path = path;
        dir = new DirectoryInfo(path);
    }

    private long FilesCount(DirectoryInfo dir)
    {
        try
        {
            int count = 0;
            if (Directory.Exists(path))
            {
                FileInfo[] fis = dir.GetFiles();
                foreach (FileInfo fi in fis)
                {
                    count++;
                }
                DirectoryInfo[] dis = dir.GetDirectories();
                foreach (DirectoryInfo di in dis)
                {
                    FilesCount(di);
                }
                return count;
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

    public int CounterFiles
    {
        get
        {
            FilesCount(dir);
            return count;
        }
        set { }
    }
}

