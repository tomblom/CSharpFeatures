namespace CSharpFeatures.CSharp11;

public class AHistoryOfNullChecks
{

    public void PerformNullCheck()
    {
        var model = GetModel();

        // Old way
        if (model == null) // Notes: model != null
        {
            Console.WriteLine("boop");
        }


        // C# 7
        if (model is null) // Notes: ! / obj / {}
        {
            Console.WriteLine("boop");
        }

        // C# 9
        if (model is not null)
        {
            Console.WriteLine("boop");
        }
    }

    public MyModel GetModel()
    {
        return new()
        {
            Name = "Hello, World!",
        };
    }
}

public class MyModel
{
    public string Name { get; set; }

    //public static bool operator ==(MyModel m1, MyModel m2)
    //{
    //    return true;
    //}

    //public static bool operator !=(MyModel m1, MyModel m2)
    //{
    //    return true;
    //}
}