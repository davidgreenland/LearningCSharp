using LearningCSharp;

var year = 2024;
var time = 13.0;
var isWarm = false;
var letter = 'y';
var timeToString = time.ToString("N2");
var todaysDate = DateTime.Now;
var objects = new List<object>([year, time, letter, isWarm, timeToString, todaysDate]);
var numberSet = new int[] { 2, 5, 7, 9, 13, 3 };

var person = new Person("Philippa", 30);
var nativeVariables = new NativeVariables(objects);

person.Greet();
nativeVariables.PrintDefinitions();
LoopDemonstration.ForLoop(5);
LoopDemonstration.WhileLoop(1, 19, 2);
LoopDemonstration.DoWhileLoop(1, 10);
LoopDemonstration.DoWhileLoop(0, 30, 3);
Utils.CheckIfEven(numberSet);

return;