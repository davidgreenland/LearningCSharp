namespace LearningCSharp.NativeVariables.Extensions;

public static class ObjectExtensions
{
    public static string GetDefinition(this object obj)
    {
        return $"This is a {obj.GetType()} value: {obj}";
    }
}