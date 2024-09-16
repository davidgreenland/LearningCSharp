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

Console.WriteLine("The following numbers are printed with a for loop");
for (var i = 1; i <= 10; ++i)
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.WriteLine("The following numbers are printed with a while loop");
var j = 1;
while (j <= 10)
{
    Console.Write($"{j} ");
    j++;
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("The following numbers are printed with a do-while loop");

var k = 1;
do
{
    Console.Write($"{k} ");
    k++;
} while (k <= 10);
Console.WriteLine();
Console.WriteLine();