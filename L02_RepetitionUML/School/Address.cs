namespace L02_RepetitionUML.School;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int PostalCode { get; set; }
    public string Country { get; set; }

    public string OutputAsLabel()
    {
        throw new NotImplementedException();
    }
    
    private bool Validate()
    {
        throw new NotImplementedException();
    }
}