using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DirEraser
    {
    private string path;

    public DirEraser(string path)
    {
        this.path = path;
    }

    private void clearFolder(string path)
    {
        try
        {
            DirectoryInfo checkDir = new DirectoryInfo(path);
            if (checkDir.Exists)
            {
                foreach (FileInfo file in checkDir.GetFiles())
                {
                        file.Delete();
                }

                foreach (DirectoryInfo dir in checkDir.GetDirectories())
                {
                        dir.Delete(true);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e}");
        }
    }

    public string DelDir
    {
        get
        {
            clearFolder(path);
            return " is clear";
        }
        set { }
    }
}
