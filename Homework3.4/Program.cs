namespace Homework3._4;

class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>
        {
            new Product("Chicken", 120, "food products"),
            new Product("Bread", 35, "food products"),
            new Product("TV", 25000, "electronics"),
            new Product("Microwave", 6300, "electronics"),
            new Product("Banana", 56, "fruits"),
            new Product("Apple", 35, "fruits"),
            new Product("Orange", 35, "fruits")
        };

        var categoryGroup = products.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Average = g.Average(p => p.Price) });

        foreach (var catecory in categoryGroup) Console.WriteLine($"Category: {catecory.Category}\n Average price: {catecory.Average}");
    }
}
