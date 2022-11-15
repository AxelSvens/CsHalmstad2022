namespace L02_RepetitionUML.School;

public abstract class Person
{
    /// <summary>
    /// Gets the name of this person
    /// </summary>
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    
    public Address Address { get; set; }

    public abstract void PurchaseParkingPass();
}
