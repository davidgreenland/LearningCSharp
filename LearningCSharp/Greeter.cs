namespace LearningCSharp;

public class Greeter : IGreeter
{
    public void Greet(string greeting)
    {
        Console.WriteLine(greeting);
    }
}