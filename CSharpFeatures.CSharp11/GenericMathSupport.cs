// Abstracting over static members

using System.Numerics;

namespace CSharpFeatures.CSharp11;

public static class GenericMathSupport
{
    public static void Demo()
    {
        int[] number = { 1, 2, 3 };


        Console.WriteLine(AddAll(number));
    }

    static int AddAll(int[] values)
    {
        int result = 0;
        foreach (var item in values)
        {
            result += item;
        }
        return result;
    }
}

// Add double??

//static T AddAll<T>(T[] values) where T : INumber<T>
//{
//    T result = T.Zero;
//    foreach (var item in values)
//    {
//        result += item;
//    }
//    return result;
//}
