namespace Homework3._2;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 2, 8, 4, 3, 6, 7 };
        int[] arr2 = { 15, 5, 6, 12, 7, 2, 3, 8, 11 };

        var allElements = arr.Concat(arr2).ToArray();

        for (var i = 0; i < allElements.Length; i++) Console.WriteLine(allElements[i]);

       // var result = string.Join(" ", allElements);
       // Console.WriteLine(result);
    }
}
