namespace Homework3._1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text");
        var input = Console.ReadLine();
        var words = input?.Split(',');

        var filteredWords = input.Split(' ').Select(str => str.Trim()).Where(str => str.StartsWith("A", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Lines starting with a letter 'A': ");

        foreach (var str in filteredWords) Console.WriteLine(str);
    }
}
