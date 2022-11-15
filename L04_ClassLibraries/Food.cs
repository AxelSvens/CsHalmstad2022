namespace L04_ClassLibraries;

public class Food : Product
{
    public Food(string name, string description) : base(name, description)
    {
    }
    
    public override void Use()
    {
        Console.WriteLine($"Im eating a delicious {Name}");
    }
}