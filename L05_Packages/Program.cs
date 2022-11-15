// See https://aka.ms/new-console-template for more information

// Packages
// Koppla till Databas

using L05_Packages;
using MySqlConnector;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        var connectionString = File.ReadAllLines("config.txt")[0];
        using var connection = new MySqlConnection(connectionString);

        // your app goes here
        var repo = new MySqlRepository(connection);
        var customers = repo.GetAllCustomers();

        while (true)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {customers[i]}");
            }
            Console.Write("Ditt val: ");
            var choice = int.Parse(Console.ReadLine()) - 1;

            var customer = customers[choice];

            customer.FirstName = ReadString("New first name", customer.FirstName);
            customer.LastName = ReadString("New last name", customer.LastName);
            customer.Phone = ReadString("New phone", customer.Phone);

            repo.Save(customer);
        }
        
    }

    static string ReadString(string message, string defaultValue = "")
    {
        Console.Write($"{message}: ");
        var input = Console.ReadLine().Trim();
        return input.Length == 0 ? defaultValue : input;
    }
}
