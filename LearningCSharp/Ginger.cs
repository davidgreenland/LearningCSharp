namespace LearningCSharp;

public class Ginger : Student
{
    public Ginger(string name, int age, int yearGroup) : base(name, age, yearGroup)
    {
        HairColour = "ginger";
    }

    public override void Greet()
    {
        base.Greet();
        Greeter.Greet($"I have flowing locks of {HairColour} hair");
    }
}