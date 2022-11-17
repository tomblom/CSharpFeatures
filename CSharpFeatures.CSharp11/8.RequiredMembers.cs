namespace CSharpFeatures.CSharp11;

public static class RequiredMembers
{

    public static void Demo()
    {
        var entity = new Entity();
    }

}

public class Entity
{
    public string Name { get; set; }
}

// C# 9 init

// C# 11 required
