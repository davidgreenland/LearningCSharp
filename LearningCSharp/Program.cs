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

for (var i = 1; i <= 10; ++i)
{
    Console.WriteLine(i);
}