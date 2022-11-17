namespace CSharpFeatures.CSharp11;

public static class ExtendedNameOf
{
    [Name(nameof(text))]
    public static void Demo(string text)
    {
    }
}

public class NameAttribute : Attribute
{
    public NameAttribute(string nameOfArgument)
    {

    }
}
