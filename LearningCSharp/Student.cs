using LearningCSharp;

public class Student : Person
{
    public int YearGroup { get; protected set; }
    public List<string> SubjectChoices { get; set; } = new List<string>();

    public Student(string name, int age, int yearGroup) : base(name, age)
    {
        YearGroup = yearGroup;
    }

    public override void Greet()
    {
        Console.WriteLine($"My Name is {Name}. I am a student in Year {YearGroup}.");
    }
}