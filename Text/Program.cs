// See https://aka.ms/new-console-template for more information

var text = " Welcome to the machine ";
PrintCentered(text, Console.WindowWidth);

string FormatCentered(string text, int width, char c = '-')
{
        var halfWidth = (width + text.Length) / 2;
        return text
                .PadLeft(halfWidth, c)
                .PadRight(Console.WindowWidth, c);
}
void PrintCentered(string text, int width)
{
        Console.WriteLine(FormatCentered(text, width));
}
