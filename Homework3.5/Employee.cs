namespace Homework3._5;

public class Employee
{
    private readonly string _surname;
    public string Name { get; set; }
    public string? Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfEmployment { get; set; }

    public Employee(string name, string surname, DateTime dateOfBirth, DateTime dateOfEmployment)
    {
        _surname = surname;
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
        DateOfEmployment = dateOfEmployment;
    }
}
