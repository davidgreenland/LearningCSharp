public class Ginger : Student, IGreetable
{
    public Ginger(string name, int age, int yearGroup) : base(name, age, yearGroup)
    {
        HairColour = "ginger";
    }

    public override void Greet()
    {
        base.Greet();
        Console.WriteLine($"I have flowing locks of {HairColour} hair");
    }
}