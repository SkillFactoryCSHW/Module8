public class Folder
{
    public List<string> Files { get; set; } = new List<string>();

    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    public void CreateFolder(string name)
    {
        Folders.Add(name, new Folder());
    }
}
