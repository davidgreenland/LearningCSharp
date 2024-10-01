namespace LearningCSharp;

public class ConsoleGreeter : IGreeter
{
    public void Greet(string greeting)
    {
        Console.WriteLine(greeting);
    }
}