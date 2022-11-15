using MySqlConnector;

namespace L05_Packages;

public class MySqlRepository : IRepository
{
    private MySqlConnection _conn;

    public MySqlRepository(MySqlConnection conn)
    {
        _conn = conn;
    }
    
    public List<Customer> GetAllCustomers()
    {
        _conn.Open();
        var query = "SELECT * FROM customer";
        var command = new MySqlCommand(query, _conn);

        var reader = command.ExecuteReader();

        List<Customer> customers = new();
        while (reader.Read())
        {
            customers.Add(new Customer()
            {
                Id = reader.GetInt32("customer_id"),
                FirstName = reader.GetString("customer_firstname"),
                LastName = reader.GetString("customer_lastname"),
                Phone = reader.GetInt32("customer_telephone").ToString(),
            });
        }
        _conn.Close();
        return customers;
    }
    public Customer? GetCustomerById(int id)
    {
        _conn.Open();
        var query = "SELECT * FROM customer WHERE customer_id = @id";
        var command = new MySqlCommand(query, _conn);
        command.Parameters.AddWithValue(
            "@id", id);
        
        var reader = command.ExecuteReader();
        var customer = !reader.Read()
            ? null
            : new Customer()
            {
                Id = reader.GetInt32("customer_id"),
                FirstName = reader.GetString("customer_firstname"),
                LastName = reader.GetString("customer_lastname"),
                Phone = reader.GetInt32("customer_telephone").ToString(),
            };
        
        _conn.Close();
        return customer;
    }

    public void Save(Customer c)
    {
        if(c.Id == 0)
            Insert(c);
        else
            Update(c);
    }

    private void Insert(Customer c)
    {
        _conn.Open();
        var query =
            "INSERT INTO customer(customer_firstname, customer_lastname,customer_telephone)" +
            "VALUES(@first_name, @last_name, @phone)";
        
        var command = new MySqlCommand(query, _conn);
        command.Parameters.AddWithValue(
            "@first_name", c.FirstName);
        command.Parameters.AddWithValue(
            "@last_name", c.LastName);
        command.Parameters.AddWithValue(
            "@phone", c.Phone);
        command.ExecuteNonQuery();
        _conn.Close();
    }
    private void Update(Customer c)
    {
        _conn.Open();
        var query =
            "UPDATE customer SET " +
            "customer_firstname = @first_name," +
            "customer_lastname = @last_name," +
            "customer_telephone = @phone " +
            "WHERE customer_id = @id";
        
        var command = new MySqlCommand(query, _conn);
        command.Parameters.AddWithValue(
            "@first_name", c.FirstName);
        command.Parameters.AddWithValue(
            "@last_name", c.LastName);
        command.Parameters.AddWithValue(
            "@phone", c.Phone);
        command.Parameters.AddWithValue(
            "@id", c.Id);
        
        command.ExecuteNonQuery();
        _conn.Close();
    }
}