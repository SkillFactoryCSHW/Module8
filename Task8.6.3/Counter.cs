using System;
using System.IO;

class Counter
{
    private string path;
    DirectoryInfo dir;
    long size;

    public Counter(string path)
    {
        this.path = path;
        dir = new DirectoryInfo(path);
    }
    
    private long DirSize(DirectoryInfo dir)
    {
        try
        {
            long size = 0;
            if (Directory.Exists(path))
            { 
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

    public long CounterSize
    {
        get
        {
            DirSize(dir);
            return size;
        }
        set { }
    }
}
