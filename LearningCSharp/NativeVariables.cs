namespace LearningCSharp;

public class NativeVariables
{
    public IEnumerable<object> Variables { get; set; }

    public NativeVariables(IEnumerable<object> variables)
    {
        Variables = variables;
    }

    public void PrintDefinitions()
    {
        foreach (var variable in Variables)
        {
            Console.WriteLine(GetDefinitionOfVariable(variable));
        }
        Console.WriteLine();
    }

    private string GetDefinitionOfVariable(object variable)
    {
        var checkType = string.Empty;

        switch (variable)
        {
            case int _:
                checkType = "an integer";
                break;
            case float:
                checkType = "a float";
                break;
            case double:
                checkType = "a double";
                break;
            case decimal:
                checkType = "a decimal";
                break;
            case bool:
                checkType = "a boolean";
                break;
            case string:
                checkType = "a string";
                break;
            case char:
                checkType = "a char";
                break;
            default:
                checkType = $"a {variable.GetType()}";
                break;
        }

        return $"This is {checkType} value: {variable}";
    }
}
