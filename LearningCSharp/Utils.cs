namespace LearningCSharp;

public static class Utils
{
    public static void CheckIfEven(int[] numbers)
    {
        Console.WriteLine("For each number in an array, a method checks if the number is even or odd and prints the result:");
        foreach (var number in numbers)
        {
            var isEven = IsEven(number);
            Console.WriteLine($"{number} is an {(isEven ? "even" : "odd")} number.");
        }
        Console.WriteLine();
    }

    private static bool IsEven(int number) => number % 2 == 0;
}