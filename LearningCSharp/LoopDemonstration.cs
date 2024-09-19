namespace LearningCSharp;

public class LoopDemonstration
{
    public static void ForLoop(int length)
    {
        Console.WriteLine("The following numbers are printed with a for loop:");
        for (var i = 1; i <= length; ++i)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    public static void WhileLoop(int start, int end, int increment)
    {
        Console.WriteLine($"Using a while loop, a list of all numbers starting at {start}, incrementing by {increment}, ending at {end}:");
        var i = start;
        while (i <= end)
        {
            Console.Write($"{i} ");
            i += increment;
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void DoWhileLoop(int start, int end, int increment = 1)
    {
        Console.WriteLine($"The following numbers are printed with a do-while loop{(increment != 1 ? $", incrementing by {increment}" : "")}:");
        var i = start;
        do
        {
            Console.Write($"{i} ");
            i += increment;
        } while (i <= end);
        Console.WriteLine();
        Console.WriteLine();
    }
}
