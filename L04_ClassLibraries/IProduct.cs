namespace L04_ClassLibraries;

public interface IProduct
{
    string Name { get; }
    string Description { get; }

    void Buy();
    void Use();
}