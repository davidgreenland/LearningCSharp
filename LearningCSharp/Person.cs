namespace LearningCSharp;

public class Person
{
    public string Name { get; set; }

    private int _age;
    public int Age
    {
        get => _age;
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
        _age = age;
    }

    public void Greet() =>
        Console.WriteLine($"Pleased to meet you. I'm {Name}.");
}