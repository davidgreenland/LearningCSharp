﻿using LearningCSharp;
using LearningCSharp.NativeVariables;

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

var numericVariables = new NativeVariables(numericValues, new DefinitionPrinter());
var moreVariables = new NativeVariables(otherObjects, new DefinitionPrinter());
var adult = new Person("Philippa", 30, new ConsoleGreeter());
var student = new Student("James", 14, 10, new ConsoleGreeter());
var gingerStudent = new Ginger("Rosanne", 12, 9, new ConsoleGreeter());
var teacher = new Teacher("Mr Grimes", 56, "Mathematics", new ConsoleGreeter());
var terminator = new Cyborg("Arnold", 1984, "T800", new ConsoleGreeter());
var people = new IGreetable[] { adult, student, gingerStudent, teacher, terminator };

numericVariables.PrintDefinitions();
moreVariables.PrintDefinitions();
LoopDemonstration.ForLoop(5);
LoopDemonstration.WhileLoop(1, 19, 2);
LoopDemonstration.DoWhileLoop(1, 10);
LoopDemonstration.DoWhileLoop(0, 30, 3);
Utils.CheckIfEven(numberSet);

adult.Age = -10;
Console.WriteLine($"{adult.Name}'s age is {adult.Age}");
gingerStudent.SubjectChoices.Add("Art and design");
foreach (var person in people)
{
    person.Greet(); 
}

return;