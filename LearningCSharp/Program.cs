using LearningCSharp;

var person = new Person("Philippa", 30);
var year = 2024;
var time = 13.0;
var isWarm = false;
var letter = 'y';
var timeToString = time.ToString("N2");
var todaysDate = DateTime.Now;
var objects = new List<object>([year, time, letter, isWarm, timeToString, todaysDate]);
var nativeVariables = new NativeVariables(objects);
var numberSet = new int[] { 2, 5, 7, 9, 13, 3 };

person.Greet();
nativeVariables.PrintDefinitions();
LoopDemonstration.ForLoop(5);
LoopDemonstration.WhileLoop(1, 19, 2);
LoopDemonstration.DoWhileLoop(1, 10);
LoopDemonstration.DoWhileLoop(0, 30, 3);
CheckIfEven(numberSet);

return;

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