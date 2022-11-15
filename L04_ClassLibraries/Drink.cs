namespace L04_ClassLibraries;

public class Drink : Product
{
    public Drink(string name, string description)
        : base(name, description)
    {
    }
    
    public override void Use()
    {
        Console.WriteLine($"Im drinking a delicious {Name}");
    }
}