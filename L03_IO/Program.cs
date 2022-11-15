var pathToFile = "hello_io.txt";
var pathToDir = "/Users/lpaz/Projects/";


#if false
Console.Clear();
PrintFiles(pathToDir);


void PrintFiles(string rootDir)
{
    if (!Directory.Exists(rootDir))
        return;
    
    foreach (var file in Directory.EnumerateFiles(rootDir))
    {
        Console.WriteLine(file);
    }
    foreach (var dir in Directory.EnumerateDirectories(rootDir))
    {
        PrintFiles(dir);
    }
}
#endif

#if false
using var reader = new StreamReader(pathToFile);
while (!reader.EndOfStream)
{
    Console.WriteLine(reader.ReadLine());
}
#endif


#if false
using var writer = new StreamWriter(pathToFile);
while (true)
{
    var line = Console.ReadLine() ?? string.Empty;
    if(string.IsNullOrEmpty(line))
        break;
    
    writer.WriteLine(line);
}
#endif

#if false
Console.Write("Tell me something in many lines: ");

List<string> sentences = new();
while (true)
{
    var sentence = Console.ReadLine();
    if(string.IsNullOrEmpty(sentence))
        break;
    sentences.Add(sentence);
}

File.AppendAllLines(pathToFile, sentences);

// The whole file
Console.WriteLine();
Console.WriteLine("The whole file contains now:");
var content = File.ReadAllText(pathToFile);
Console.WriteLine(content);
#endif
