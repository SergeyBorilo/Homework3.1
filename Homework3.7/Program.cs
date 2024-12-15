namespace Homework3._7;

class Program
{
    static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
            new Customer("Sergey", "Popov", "Dnepr, str. Central 56", new List<(string OrderName, int Amount)>
            {
                ("Iphone 14", 33000)
            }),
            new Customer("Jeck", "Haris", "Odessa, str. Kachinskogo 19", new List<(string OrderName, int Amount)>
            {
                ("TV Samsung", 28000)
            }),
            new Customer("Roy", "Beeber", "NewYork, str. Vashington 158", new List<(string OrderName, int Amount)>
                {
                    ("TV LG", 45000)
                }),
            new Customer("Oleg", "Galushko", "Denver, str. Tennyson 88", new List<(string OrderName, int Amount)>
            {
                ("Razor", 500)
            }),
            new Customer("Andre", "Stalone", "Vancouver, str. Quebec 25",new List<(string OrderName, int Amount)>
            {
                ("Router", 999)
            }),
            new Customer("Olga", "Baranova", "Dnepr, str. Central 56", new List<(string OrderName, int Amount)>
            {
                ("Pan", 888)
            })
        };

        var customersWithLargeOrders = customers.Where(c => c.Orders.Any(o => o.Amount > 1000));

        foreach (var customer in customersWithLargeOrders)
        {
            Console.WriteLine($"Customer: {customer.Name} {customer.Surname}, " +
                              $"Adress: {customer.Address}");

            foreach (var order in customer.Orders) Console.WriteLine($"Order: {order.OrderName} {order.Amount}");
        }
    }
}
