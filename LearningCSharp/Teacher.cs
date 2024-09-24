using LearningCSharp;

class Teacher: Person
{
    public string Department { get; protected set; }

    public Teacher(string name, int age, string department) : base(name, age) 
    {
        Department = department;
    }
}