namespace L02_RepetitionUML.Orders;

public abstract class Order
{
    public DateOnly Date { get; set; }
    public string Number { get; set; }

    public void Confirm()
    {
        
    }

    public void Close()
    {
        
    }
}