namespace L04_ClassLibraries;

public class Alcohol : Drink
{
    public Alcohol(string name, string description) : base(name, description)
    {
    }

    public override void Buy()
    {
        if (IsLegal())
        {
            base.Buy();
        }
        else
        {
            Console.WriteLine("Can't buy alcohol, young soul!");
        }
    }

    private bool IsLegal() => Environment.TickCount % 2 == 0;
}