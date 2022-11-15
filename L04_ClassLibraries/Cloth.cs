namespace L04_ClassLibraries;

public class Cloth : Product
{
    public Cloth(string name, string description) : base(name, description)
    {
    }
    
    public override void Use()
    {
        Console.WriteLine($"I'm wearing a trending {Name}");
    }
}