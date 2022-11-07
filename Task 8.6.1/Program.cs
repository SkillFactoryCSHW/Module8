using System;
using System.IO;

//Path to your f
string folderName = @"C\\Files\Test";

DirEraser eraser = new DirEraser(folderName);

Console.WriteLine($"{folderName} { eraser.CheckDir}");
