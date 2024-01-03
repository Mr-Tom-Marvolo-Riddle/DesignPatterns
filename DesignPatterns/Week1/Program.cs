// See https://aka.ms/new-console-template for more information
using QuickFind;

Console.WriteLine("Hello, World!");

var fileContent = File.ReadAllText("Input.txt");
if (string.IsNullOrWhiteSpace(fileContent))
{
    Console.WriteLine("File Content is empty.");
    return;
}

var lines = fileContent.Split('\n');
if (lines.Length < 2)
{
    Console.WriteLine("Invalid content.");
    return;
}

var firstLine = lines[0];
if (!int.TryParse(firstLine, out int totalItems))
{
    Console.WriteLine("Invalid total items.");
    return;
}

var nextLine = lines[1];
if (string.IsNullOrWhiteSpace(nextLine))
{
    Console.WriteLine("Invalid unions.");
    return;
}

List<Union> unions = new List<Union>();
var unionsInput = nextLine.Split(' ');
foreach (var item in unionsInput)
{
    if (!item.Contains(','))
    {
        continue;
    }

    var unionParts = item.Split(",");
    if (unionParts.Length < 2)
        continue;

    if (!int.TryParse(unionParts[0], out int start) && start >= totalItems)
    {
        continue;
    }

    if (!int.TryParse(unionParts[1], out int end) && end >= totalItems)
    {
        continue;
    }

    unions.Add(new Union() { Start = start, End = end });
}

// Process union find.
Console.ReadLine();