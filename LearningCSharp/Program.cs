using LearningCSharp;

var year = 2024;
var floatingPoint = 5.4f;
var annualSalary = 100000m;
var monthlySalary = annualSalary / 12;
var monthlySalaryAsString = monthlySalary.ToString("N2");
var binaryLiteral = 0b_0010_1010;
var isWarm = false;
var letter = 'y';
var todaysDate = DateTime.Now;
var numericValues = new object[] { year, floatingPoint, monthlySalary, binaryLiteral };
var otherObjects = new object[] { letter, monthlySalaryAsString, isWarm, todaysDate };
var numberSet = new int[] { 2, 5, 7, 9, 13, 3 };

var numericVariables = new NativeVariables(numericValues);
var moreVariables = new NativeVariables(otherObjects);
var adult = new Person("Philippa", 30);
var student = new Student("James", 14, 10);
var ginger = new Ginger("Rosanne", 12, 9);
var teacher = new Teacher("Mr Grimes", 56, "Mathematics");
var people = new Person[] { adult, student, ginger, teacher };

numericVariables.PrintDefinitions();
moreVariables.PrintDefinitions();
LoopDemonstration.ForLoop(5);
LoopDemonstration.WhileLoop(1, 19, 2);
LoopDemonstration.DoWhileLoop(1, 10);
LoopDemonstration.DoWhileLoop(0, 30, 3);
Utils.CheckIfEven(numberSet);

adult.Age = -10;
Console.WriteLine(adult.Age); // still 30
ginger.SubjectChoices.Add("Art and design");
foreach (var person in people)
{
    person.Greet();
}

return;
