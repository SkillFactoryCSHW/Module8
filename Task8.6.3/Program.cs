using System;
using System.IO;

//Path to your folder
string path = @"C\Files\Test";

Counter counter = new Counter(path);
FilesCounter filesCounter = new FilesCounter(path);
DirEraser dirEraser = new DirEraser(path);

Console.WriteLine($"{path} size: {counter.CounterSize}");
Console.WriteLine($"{path} amount of files: {filesCounter.CounterFiles}");
Console.WriteLine($"{path} {dirEraser.DelDir}");
