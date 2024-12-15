namespace Homework3._7;

public class Customer
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public List<(string OrderName, int Amount)> Orders { get; }

    public Customer(string name, string surname, string address, List<(string OrderName, int Amount)> orders)
    {
        Name = name;
        Surname = surname;
        Address = address;
        Orders = orders;
    }
}
