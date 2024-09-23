using LearningCSharp;

class Student : Person
{
    public int YearGroup { get; protected set; }
    public List<string> SubjectChoices { get; set; } = new List<string>();
    public Student(string name, int age, int yearGroup) : base(name, age)
    {
        YearGroup = yearGroup;
    }

    public override void Greet()
    {
        Console.WriteLine($"I am a student in Year {YearGroup}. My Name is {Name}. I have {HairColour} hair");
    }
}

class Ginger : Student
{
    public Ginger(string name, int age, int yearGroup) : base(name, age, yearGroup)
    {
        HairColour = "ginger";
    }
}