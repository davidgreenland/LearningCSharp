namespace LearningCSharp;

public class Student : Person
{
    public int YearGroup { get; protected set; }
    public List<string> SubjectChoices { get; set; } = new ();

    public Student(string name, int age, int yearGroup, IGreeter greeter) : base(name, age, greeter)
    {
        YearGroup = yearGroup;
    }

    public override void Greet()
    {
        _greeter.Greet($"My Name is {Name}. I am a student in Year {YearGroup}.");
    }
}