namespace L02_RepetitionUML.Categories;

public class Category
{
    public string Name { get; set; }
    public List<Product> Products { get; } = new();
}
