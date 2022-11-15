using CoolMath;
using L04_ClassLibraries;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements


// assembly
// project
// public vs internal

class Program
{
    static void Main(string[] args)
    {
        // if array contains repeated numbers
        int[] numbers = {1, 2, 3, 4, 5, 6, 4, 4, 8, 9};

        // for, while, foreach <=> break, continue
        
        for (int i = 0; i < 4; i++)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            
            if(string.IsNullOrEmpty(name))
                break;
            
            Console.WriteLine($"hello, {name}");
        }

        Console.WriteLine("Good enough, dude. Go home!");
        return;
        
        while (true)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            
            if(string.IsNullOrEmpty(name))
                break;
            
            Console.WriteLine($"hello, {name}");
        }

        return;
        
        foreach (var number in numbers)
        {
            // this is not executed when n != 4
            if(number != 4)
                continue; // im not interested
            
            // n = 4
            Console.WriteLine("This");
            Console.WriteLine("is");
            Console.WriteLine("really");
            Console.WriteLine("cool");
            Console.WriteLine();
        }
        
        // 1. take next item from items
        // 2. if none, exit
        // 3. otherwise run the block (print)
        // 4. repeat 1.
        
        return;
        
        // How for-loops run
        // 1. initialize (i = 0)
        // 2. check condition (i < length)
        // 3. if true execute block (print) else exit
        // 4. update (i++)
        // 5. repeat step 2.
        
        bool repeated = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i == j) continue;
                if (numbers[i] == numbers[j])
                {
                    repeated = true;
                    break;
                }
            }
            
            if(repeated)
                break;
        }

        Console.WriteLine(repeated);
    }

    static bool IsRepeated(int[] numbers, int number)
    {
        int count = 0;
        foreach (var n in numbers)
        {
            if (n == number)
                count++;
            
            if (count > 1)
                return true;
        }

        return false;
    }
    
    static int Count(int[] numbers, int number)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
                count++;
        }

        return count;
    }
    
    static void RunMenuApp()
    {
        IProduct[] products = InitProductsList();
        
        while (true)
        {
            ShowMenu(products);
            var choice = ReadChoice("Your choice: ");
            if(choice == -1)
                break;
            
            var chosenProduct = products[choice];
        
            chosenProduct.Buy();
            chosenProduct.Use();
            
            Console.ReadKey(true);
        }
    }
    
    static void ShowMenu(IProduct[] products)
    {
        Console.Clear();
        
        for (int i = 0; i < products.Length; i++)
            Console.WriteLine($"{i + 1}- {products[i].Name}");

        Console.WriteLine($"{products.Length + 1}- Quit");
        
        Console.WriteLine();
    }

    static IProduct ChooseProduct(IProduct[] products)
    {
        var choice = ReadChoice("Your choice: ");
        return products[choice - 1];
    }

    static int ReadChoice(string message)
    {
        Console.Write(message);
        var choice = int.Parse(Console.ReadLine() ?? string.Empty);
        return choice - 1;
    }
    
    static IProduct[] InitProductsList()
    {
        return new IProduct[]
        {
            new Food("Chips", "Nasty"),
            new Food("Burger", "Makes you fat, yet happy"),
        
            new Drink("Zingo", "best orange soda"),
            new Drink("CocaCola", "capitalism sign"),
            
            new Cloth("T-shirt", "Never in winter"),
            new Cloth("Tröja", "Nice and warm"),
            
            new Alcohol("Prips blå", "Ses under bordet")
        };
    }
}
