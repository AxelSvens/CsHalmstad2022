namespace CoolMath;

internal class Printer
{
    public void Print<T>(T[] items)
    {
        Console.WriteLine($"[{string.Join(", ", items)}]");
    }
}
