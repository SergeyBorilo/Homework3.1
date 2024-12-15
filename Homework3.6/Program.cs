namespace Homework3._6;

class Program
{
    static void Main(string[] args)
    {
        var books = new List<Book>()
        {
            new Book("Dune", "Frank Herber", 2015, "Fantasy"),
            new Book("Kobzar", "Shevchenko", 1840, "Classic"),
            new Book("Just After Sunset", "Stephen King", 2008, "Fantasy"),
            new Book("I look into your pupils", "Vasyl Simonenko", 2019, "Classic"),
            new Book("Dracula", "Stoker Bram", 2010, "Horror"),
        };

        var recentBooks = books.Where(b => b.YearOfPublication > 2010 && b.Genre == "Fantasy").ToList();

        foreach (var book in recentBooks)
        {
            Console.WriteLine($"Name: {book.Title},\n Autor: {book.Author},\n " +
                              $"Year Of Publication: {book.YearOfPublication},\n Genre: {book.Genre}");
        }
    }
}
