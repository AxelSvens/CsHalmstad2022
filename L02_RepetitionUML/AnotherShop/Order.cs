namespace L02_RepetitionUML.AnotherShop;

public class Order
{
    private readonly List<OrderLine> _orderLines = new();
    
    public DateOnly ReceivedOn { get; set; }
    public bool IsPrepaid { get; set; }
    public string Number { get; set; }

    public Customer Customer { get; set; }
    
    public decimal Price
    {
        get
        {
            var price = 0.0m;
            
            foreach (var ol in OrderLines)
                price += ol.Price * ol.Quantity;
            
            return price;
        }
    }

    public List<OrderLine> OrderLines
    {
        get
        {
            return _orderLines;
        }
    }
    
    
    public void Dispatch()
    {
    }

    public void Close()
    {
    }
}
