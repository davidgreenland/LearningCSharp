namespace LearningCSharp;

public class Person
{
    public string Name { get; set; }

    protected string HairColour = "not provided";

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
        _age = age;=///*KKKkkkKKKK;;;''''###
    }

    public virtual void Greet() =>
        Console.WriteLine($"Pleased to meet you. My name is {Name}.");
}