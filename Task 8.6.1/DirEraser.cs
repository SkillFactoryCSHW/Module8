using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
                        if (DateTime.Now - file.CreationTime < TimeSpan.FromMinutes(30))
                        {
                            file.Delete();
                        }
                    }

                    foreach (DirectoryInfo dir in checkDir.GetDirectories())
                    {
                        if (DateTime.Now - dir.CreationTime < TimeSpan.FromMinutes(30))
                        {
                            dir.Delete(true);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
        }

        public string CheckDir
        {
            get
            {
                clearFolder(path);
                return " is clear";
            }
            set {}
        }
    }

