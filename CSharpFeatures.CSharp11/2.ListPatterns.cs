using System.Linq;

namespace CSharpFeatures.CSharp11;

public static class ListPatterns
{
    public static void Demo()
    {
        int[] numbers = { 1, 2, 3 };

        Console.WriteLine(numbers is [1, 2, 3]); // true

        Console.WriteLine(numbers is [1, 2, 4]); // false

        Console.WriteLine(numbers is [1, 2, 3, 4]); // false

        Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // true

        if (numbers is [var first, _, _]) // Notes: .. var rest
        {
            Console.WriteLine(first);
        }

        var name = new[] { "Thomas", "Peter", "Blomfield" };

        var text = name switch
        {
            [] => "Name is Empty",
            [var firstName] => $"My First name is {firstName}",
            [var firstName, .. var middleAndLast] => $"My full name is {firstName} {string.Join(" ", middleAndLast)}"
        };

        Console.Write(text);
    }
}
