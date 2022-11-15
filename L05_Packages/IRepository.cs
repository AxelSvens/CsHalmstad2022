namespace L05_Packages;

public interface IRepository
{
    List<Customer> GetAllCustomers();
    void Save(Customer c);
}