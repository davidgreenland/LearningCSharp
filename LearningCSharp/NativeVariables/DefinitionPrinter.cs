using LearningCSharp.NativeVariables.Extensions;

namespace LearningCSharp.NativeVariables;

public class DefinitionPrinter : IDefinitionPrinter
{
    public void Print(IEnumerable<object> variables)
    {
        foreach (var variable in variables)
        {
            Console.WriteLine(variable.GetDefinition());
        }
        Console.WriteLine();
    }
}