namespace CSharpFeatures.CSharp11;

internal static class AutoDefaultStructs
{
}

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
