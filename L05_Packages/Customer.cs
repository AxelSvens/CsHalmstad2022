namespace L05_Packages;

public class Customer
{
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}