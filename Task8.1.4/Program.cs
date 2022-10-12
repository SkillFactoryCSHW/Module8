public class Drive
{
    public Drive(string name, long space, long freeSpace)
    {
        Name = name;
        Space = space; 
        FreeSpace = freeSpace;
    }

    public string Name { get; }
    public long Space { get; }
    public long FreeSpace { get; }
}