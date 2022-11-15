class Program
{
    static void Main()
    {
        int[] denominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] counts = { 2, 0, 1, 0, 0, 0, 0, 10, 0, 10 };

        int[] shortDenom = { 20, 10, 5, 1 };
          // 360
        
        
        while (true)
        {
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;
            
            int amount = int.Parse(input);
            int[] wallet = { 10, 10, 10, 10 };
            PrintWallet(wallet, shortDenom);
            GiveBack(amount, shortDenom, wallet);
            PrintWallet(wallet, shortDenom);
            
            // PrintGiveBack(amount, denominations);

        }
        
        
    }

    // 2345 -> 2 x 1000
    //  345 -> 0 x 500
    //  345 -> 1 x 200
    //  145 -> 0 x 500
    
    
    static void PrintGiveBack(int amount, int[] denominations) // denominations are sorted desc
    {
        foreach (var denomination in denominations)
        {
            if (amount == 0)
                break;

            var count = amount / denomination;
            if (count > 0)
                Console.WriteLine($"{count} x {denomination}");
            
            amount %= denomination;
        }
    }
    
    static void GiveBack(int amount, int[] denominations, int[] wallet) // denominations are sorted desc
    {
        var saldo = TotalAmount(wallet, denominations);
        
        if (saldo < amount)
            throw new InvalidOperationException("Not enough fund");

        for (int i = 0; i < wallet.Length; i++)
        {
            var denomination = denominations[i];
            
            var count = Math.Min(amount / denomination, wallet[i]);
            wallet[i] -= count;

            amount -= count * denomination;
        }
    }

    static int TotalAmount(int[] wallet, int[] denominations)
    {
        var total = 0;
        for (int i = 0; i < wallet.Length; i++)
            total += wallet[i] * denominations[i];

        return total;
    }
    
    // 3500
    // 
    
    static int[] SplitAmount(int amount, int[] denominations)
    {
        int[] counts = new int [denominations.Length];
        for (int i = 0; i < denominations.Length; i++)
        {
            counts[i] = amount / denominations[i];
            amount %= denominations[i];
        }
        return counts;
    }

    static void PrintWallet(int[] wallet, int[] denominations)
    {
        for (int i = 0; i < wallet.Length; i++)
        {
            Console.Write($"{wallet[i]}x{denominations[i]}kr, ");
        }

        Console.WriteLine();
    }
    
    static void PutBack(int amount, int[] denominations, int[] wallet)
    {
        var change = SplitAmount(amount, denominations);
        for (var i = 0; i < wallet.Length; i++)
            wallet[i] += change[i];
    }
}

class Product
{
    public void Buy(Wallet w)
    {
        
    }
}

class Wallet
{
    private int[] _counts;
    private int _saldo;

    public int Count(int denomination)
    {
        
        return default;
    }
}

class Atm
{
    bool SetIn(int denomination, int count, Wallet w)
    {
        if (w.Count(denomination) < count)
            return false;
        return true;
    }

    public void Buy(Product c, Wallet w)
    {
        
    }
}

class Denomination
{
    int[] denominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
    public int IndexOf(int denomination) => Array.IndexOf(denominations, denomination);
}