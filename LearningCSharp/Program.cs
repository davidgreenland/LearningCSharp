using LearningCSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        var year = 2024;
        var floatingPoint = 5.4f;
        var annualSalary = 100000m;
        var monthlySalary = annualSalary / 12;
        var monthlySalaryAsString = monthlySalary.ToString("N2");
        var binaryLiteral = 0b_0010_1010;
        var isWarm = false;
        var letter = 'y';
        var todaysDate = DateTime.Now;
        var numericValues = new List<object>([year, floatingPoint, monthlySalary, binaryLiteral]);
        var otherObjects = new List<object>([letter, monthlySalaryAsString, isWarm, todaysDate]);
        var numberSet = new int[] { 2, 5, 7, 9, 13, 3 };

        var numericVariables = new NativeVariables(numericValues);
        var moreVariables = new NativeVariables(otherObjects);
        var person = new Person("Philippa", 30);
        var student = new Student("James", 14, 10);
        var ginger = new Ginger("Rosanne", 12, 9);
        var teacher = new Teacher("Mr Grimes", 56, "Mathematics");


        numericVariables.PrintDefinitions();
        moreVariables.PrintDefinitions();
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
        ginger.SubjectChoices.Add("Art and design");
        teacher.Greet();

        return;
    }
}