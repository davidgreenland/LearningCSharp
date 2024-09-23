using LearningCSharp;

var year = 2024;
var binaryLiteral = 0b_0010_1010;
var floatingPoint = 5.4f;
var time = 13.0;
var isWarm = false;
var letter = 'y';
var timeToString = time.ToString("N2");
var todaysDate = DateTime.Now;
var objects = new List<object>([year, time, floatingPoint, letter, binaryLiteral, isWarm, timeToString, todaysDate]);
var numberSet = new int[] { 2, 5, 7, 9, 13, 3 };

var person = new Person("Philippa", 30);
var student = new Student("James", 14, 10);
var ginger = new Ginger("Rosanne", 12, 9);
var nativeVariables = new NativeVariables(objects);

nativeVariables.PrintDefinitions();
LoopDemonstration.ForLoop(5);
LoopDemonstration.WhileLoop(1, 19, 2);
LoopDemonstration.DoWhileLoop(1, 10);
LoopDemonstration.DoWhileLoop(0, 30, 3);
Utils.CheckIfEven(numberSet);

person.Greet();
person.Age = -10;
Console.WriteLine(person.Age); // still 30
student.Greet();
ginger.Greet();

return;