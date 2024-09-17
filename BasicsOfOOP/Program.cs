var person = new Person("Philippa", 30);
person.Greet();

public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello {Name}.");
    }
}