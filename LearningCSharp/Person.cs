namespace LearningCSharp;

public class Person : IGreetable
{
    public string Name { get; set; }
    protected string HairColour = "not provided";
    protected readonly IGreeter _greeter;

    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value > 0)
            {
                _age = value;
            }
        }
    }

    public Person(string name, int age, IGreeter greeter)
    {
        Name = name;
        Age = age;
        _greeter = greeter;
    }

    public virtual void Greet() =>
        _greeter.Greet($"Pleased to meet you. My name is {Name}.");
}