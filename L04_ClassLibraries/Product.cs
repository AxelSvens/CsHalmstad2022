namespace L04_ClassLibraries;

public abstract class Product : IProduct
{
    public string Name { get; }
    public string Description { get; }

    public Product(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Buy()
    {
        Console.WriteLine($"I'm buying base a {Name}");
    }

    public abstract void Use();
}