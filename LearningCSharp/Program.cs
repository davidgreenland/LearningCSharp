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

var k = 1;
do
{
    Console.Write($"{k} ");
    k++;
} while (k <= 10);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("A random number between 1 and 10 is generated.");
Console.WriteLine("An if-else statement checks if a number is even or odd, and outputs the result:");
Random rnd = new Random();
int number = rnd.Next(1, 11);
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is an even number.");
}
else
{
    Console.WriteLine($"{number} is an odd number.");
}