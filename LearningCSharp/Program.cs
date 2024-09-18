using LearningCSharp;

const string NAME = "Abdullah";
var year = 2024;
var time = 13.0;
var isWarm = false;
var timeToString = time.ToString("N2");
var todaysDate = DateTime.Now;
var objects = new List<object>([year, time, NAME, isWarm, timeToString, todaysDate]);
var numberSet = new int[] { 2, 5, 7, 9, 13, 3 };
var person = new Person("Philippa", 30);

//Greet(NAME);
//PrintDefinitions(objects);
//ForLoopDemonstration(5);
//WhileLoopDemonstration(1, 19, 2);
//DoWhileLoopDemonstration(1, 10);
//DoWhileLoopDemonstration(0, 30, 3);
//CheckIfEven(numberSet);
person.Greet();
Console.WriteLine(person.Age);

void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

void PrintDefinitions(IEnumerable<object> inputs)
{
    foreach (var input in inputs)
    {
        Console.WriteLine(GetDefinitionOfInput(input));
    }
    Console.WriteLine();
}

string GetDefinitionOfInput(object input)
{
    var checkType = string.Empty;

    switch (input)
    {
        case int _:
            checkType = "an integer";
            break;
        case double:
            checkType = "a double";
            break;
        case bool:
            checkType = "a boolean";
            break;
        case string:
            checkType = "a string";
            break;
        default:
            checkType = $"a {input.GetType().ToString()}";
            break;
    }

    return $"This is {checkType} value: {input}";
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
    var i = start;
    while (i <= end)
    {
        Console.Write($"{i} ");
        i += increment;
    }
    Console.WriteLine();
    Console.WriteLine();
}

void DoWhileLoopDemonstration(int start, int end, int increment = 1)
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

void CheckIfEven(int[] numbers)
{
    Console.WriteLine("For each number in an array, a method checks if the number is even or odd and prints the result:");
    foreach (var number in numbers)
    {
        var isEven = IsEven(number);
        Console.WriteLine($"{number} is an {(isEven ? "even" : "odd")} number.");
    }
}

bool IsEven(int number) => number % 2 == 0;