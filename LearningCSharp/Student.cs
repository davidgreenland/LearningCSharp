using LearningCSharp;

class Student : Person
{
    public int YearGroup { get; protected set; }
    public Student(string name, int age, int yearGroup) : base(name, age)
    {
        YearGroup = yearGroup;
    }

    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("I am in Year" + " " + YearGroup);
    }
}