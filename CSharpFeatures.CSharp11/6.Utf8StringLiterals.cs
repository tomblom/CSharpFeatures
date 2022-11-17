namespace CSharpFeatures.CSharp11;

public static class Utf8StringLiterals
{
    public static void Demo()
    {
        string text = "Hello, world!"; // UTF16

        ReadOnlySpan<byte> u8Text = "Hello, World!"u8;
    }
}
