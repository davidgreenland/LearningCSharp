namespace LearningCSharp;

public class Ginger : Student
{
    public Ginger(string name, int age, int yearGroup, IGreeter greeter) : base(name, age, yearGroup, greeter)
    {
        HairColour = "ginger";
    }

    public override void Greet()
    {
        base.Greet();
        _greeter.Greet($"I have flowing locks of {HairColour} hair");
    }
}