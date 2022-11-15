namespace L02_RepetitionUML.Orders;

public class Customer
{
    private List<Order> _orders = new();
    
    public string Name { get; set; }
    public string Location { get; set; }

    public List<Order> Orders
    {
        get
        {
            return _orders;
        }
    }
    
    public void SendOrder()
    {
        
    }
    public void ReceiveOrder()
    {
        
    }
}