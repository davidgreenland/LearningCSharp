namespace LearningCSharp;

public class Teacher : Person
{
    public string Department { get; protected set; }

    public Teacher(string name, int age, string department, IGreeter greeter) : base(name, age, greeter)
    {
        Department = department;
    }

    public override void Greet()
    {
        _greeter.Greet($"Hello, my name is {Name}. I work in the {Department} department.");
    }
}