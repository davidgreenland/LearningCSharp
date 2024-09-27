public class Cyborg : IGreetable
{
    public string Name { get; private set; }
    public int YearOfManufacture { get; private set; } = DateTime.Now.Year;
    public string Model { get; private set; }

    public Cyborg(string name, int yearOfManufacture, string model )
    {
        Name = name;
        YearOfManufacture = yearOfManufacture;
        Model = model;
    }

    public void Greet() =>
        Console.WriteLine($"Hasta la vista");
}