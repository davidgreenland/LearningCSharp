Console.WriteLine("Hello, World!");

var year = 2024;
var time = 0.0;
var name = "Abdullah";
var isWarm = false;
var timeToString = time.ToString("N2");

Console.WriteLine($"This is an integer value: {year}");
Console.WriteLine($"This is a double value: {timeToString}");
Console.WriteLine($"This is a string value: {name}");
Console.WriteLine($"This is a boolean value: {isWarm}");
Console.WriteLine();

Console.WriteLine("The following numbers are printed with a for loop:");
for (var i = 1; i <= 10; ++i)
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.WriteLine("The following numbers are printed with a while loop:");
var j = 1;
while (j <= 10)
{
    Console.Write($"{j} ");
    j++;
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("The following numbers are printed with a do-while loop:");
j = 1;
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

static bool IsEven(int number) => number % 2 == 0;