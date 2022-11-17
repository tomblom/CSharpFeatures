namespace CSharpFeatures.CSharp11;

public static class PatternMatchSpan
{
    public static void Demo()
    {
        // ReadOnlySpan<char> / strings
        string text = "Tom Blomfield";

        if (text is "Tom Blomfield")
        {
            Console.WriteLine("YES");
        }

        if (text is ['T', ..])
        {
            Console.WriteLine("Name starts with T");
        }
    }
}
