using LearningCSharp;

public class Teacher : Person, IGreetable
{
    public string Department { get; protected set; }

    public Teacher(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    public override void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}. I work in the {Department} department.");
    }
}