var year = 2024;
var time = 13.0;
var name = "Abdullah";
var isWarm = false;
var timeToString = time.ToString("N2");
var todaysDate = DateTime.Now;

var objects = new List<object>([year, time, name, isWarm, timeToString, todaysDate]);
PrintDefinitions(objects);
ForLoopDemonstration(5);
WhileLoopDemonstration(1, 19, 2);


Console.WriteLine("The following numbers are printed with a do-while loop:");
var j = 1;
do
{
    Console.Write($"{j} ");
    j++;
} while (j <= 10);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("For each number in an array, a method checks if the number is even or odd and prints the result:");
var numberSet = new int[] { 2, 5, 7, 9, 13, 3 };
foreach (var number in numberSet)
{
    var isEven = IsEven(number);
    Console.WriteLine($"{number} is an {(isEven ? "even" : "odd")} number.");
}
void PrintDefinitions(List<object> inputs)
{
    foreach (var input in inputs)
    {
        Console.WriteLine(GetDefinitionOfInput(input));
    }
    Console.WriteLine();
}

string GetDefinitionOfInput(object input) => $"This is {CheckType(input)} value: {input}";
string CheckType(object input)
{
    if (input is System.Int32)
        return "an integer";
    if (input is System.Double)
        return "a double";
    if (input is System.String)
        return "a string";
    if (input is System.Boolean)
        return "a boolean";
    return $"a {input.GetType().ToString()}";
}
void ForLoopDemonstration(int length)
{
    Console.WriteLine("The following numbers are printed with a for loop:");
    for (var i = 1; i <= length; ++i)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}
void WhileLoopDemonstration(int start, int end, int increment)
{
    Console.WriteLine($"Using a while loop, a list of all numbers starting at {start}, incrementing by {increment}, ending at {end}:");
    var j = start;
    while (j <= end)
    {
        Console.Write($"{j} ");
        j += increment;
    }
    Console.WriteLine();
    Console.WriteLine();
}
bool IsEven(int number) => number % 2 == 0;