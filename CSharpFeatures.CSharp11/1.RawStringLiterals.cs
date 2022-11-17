namespace CSharpFeatures.CSharp11;

// https://devblogs.microsoft.com/dotnet/csharp-11-preview-updates/
public static class RawStringLiterals
{

    // <?xml version="1.0" encoding="UTF-8"?>
    public static void Demo()
    {
        string xmlProlog = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";

        Console.WriteLine(xmlProlog);

        // verbatim string
        string verbatim = @"<?xml version=""1.0"" encoding=""UTF-8""?>";

        Console.WriteLine(verbatim);

        string rawString = """<?xml version="1.0" encoding="UTF-8"?>""";

        Console.WriteLine(rawString);


        string json =
"""
{
    "name" : "Tom Blom",
}
""";

        Console.WriteLine(json);


        string name = "Tom";
        string interpolatedJson =
                    $$"""
                    {
                        "name" : "{{name}}",
                    }
                    """;

        Console.WriteLine(interpolatedJson);
    }
}
