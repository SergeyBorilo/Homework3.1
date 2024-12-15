namespace Homework3._4;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }

    public Product(string name, int price, string category)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}
