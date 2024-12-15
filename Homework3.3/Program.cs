namespace Homework3._3;

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student("Sergey", "Popov", 94),
            new Student("Jeck", "Haris", 90),
            new Student("Roy", "Beeber", 82),
            new Student("Oleg", "Galushko", 66),
            new Student("Andre", "Stalone", 89),
            new Student("Olga", "Baranova", 98)
        };


        var topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();

        if (topStudent != null)
            Console.WriteLine($"Max grade {topStudent.Name} {topStudent.Surname} is {topStudent.Grade}");
        else
            Console.WriteLine("No student found");
    }
}
