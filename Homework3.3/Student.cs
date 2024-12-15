namespace Homework3._3;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Grade { get; set; }

    public Student(string name, string surname, int grade)
    {
        Name = name;
        Surname = surname;
        Grade = grade;
    }
}
