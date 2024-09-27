namespace LearningCSharp;

public class Person : IGreetable
{
    public string Name { get; set; }
    protected string HairColour = "not provided";
    protected readonly Greeter _greeter;

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

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        _greeter = new Greeter();
    }

    public virtual void Greet() =>
        Greeter.Greet($"Pleased to meet you. My name is {Name}.");
}