using HW5.Interface;
using Directory = HW5.Models.Directory;
using File = HW5.Models.File;

internal class Program
{
    private static void Main(string[] args)
    {
        Directory root = new Directory("root", 
            new SysFileComponent[] {new File("rootFile.txt"), new Directory("rootDir",
                new SysFileComponent[] {new File("middleFile.txt"), new Directory("middleDir",
                    new SysFileComponent[] {new File("bottomFile1.txt"), new File("bottomFile2.txt"), new Directory("bottomDir")})})});

        root.DisplayInfo(0);

        Console.ReadKey();
    }
}