namespace LearningCSharp;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet() =>
        Console.WriteLine($"Pleased to meet you. I'm {Name}.");
}