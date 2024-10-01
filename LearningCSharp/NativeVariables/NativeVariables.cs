namespace LearningCSharp.NativeVariables;

public class NativeVariables
{
    private readonly IEnumerable<object> Variables;
    private readonly IDefinitionPrinter _printer;

    public NativeVariables(IEnumerable<object> variables, IDefinitionPrinter printer)
    {
        Variables = variables;
        _printer = printer;
    }

    public void PrintDefinitions()
    {
        _printer.Print(Variables);
    }
}