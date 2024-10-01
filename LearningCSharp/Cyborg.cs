namespace LearningCSharp;

public class Cyborg : IGreetable
{
    public string Name { get; private set; }
    public int YearOfManufacture { get; private set; } = DateTime.Now.Year;
    public string Model { get; private set; }
    public readonly IGreeter _greeter;

    public Cyborg(string name, int yearOfManufacture, string model, IGreeter greeter)
    {
        Name = name;
        YearOfManufacture = yearOfManufacture;
        Model = model;
        _greeter = greeter;
    }

    public void Greet() =>
        _greeter.Greet($"Hasta la vista");
}