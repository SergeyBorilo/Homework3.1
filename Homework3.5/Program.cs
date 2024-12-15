namespace Homework3._5;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee("Sergey", "Popov", new DateTime(1993, 2, 15), new DateTime(2021, 6, 2)),
            new Employee("Jeck", "Haris", new DateTime(1989, 7, 29), new DateTime(2010, 10, 1)),
            new Employee("Roy", "Beeber", new DateTime(1995, 1, 1), new DateTime(2020, 5, 12)),
            new Employee("Oleg", "Galushko", new DateTime(1990, 12, 31), new DateTime(2011, 11, 11)),
            new Employee("Andre", "Stalone", new DateTime(1991, 5, 8), new DateTime(2015, 5, 28)),
            new Employee("Olga", "Baranova", new DateTime(1995, 8, 25), new DateTime(2022, 3, 3))
        };

        var today = DateTime.Now;

        var logTermEmployees = employees.Where(e => (today - e.DateOfEmployment).TotalDays > 5 * 365).ToList();

        foreach (var employee in logTermEmployees)
        {
            Console.WriteLine($"Have been working for more than 5 years: {employee.Name} {employee.Surname} - " +
                              $" Date of employment: {employee.DateOfEmployment.ToShortDateString()}");
        }
    }
}
