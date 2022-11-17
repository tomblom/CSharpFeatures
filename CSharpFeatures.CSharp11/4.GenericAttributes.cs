namespace CSharpFeatures.CSharp11;

[OldValidator(typeof(IUserValidator))]
public class User
{
    public int Id { get; set; }
}

public interface IUserValidator { }

public class OldValidatorAttribute : Attribute
{
    public Type ValidatorType { get; }

    public OldValidatorAttribute(Type type)
    {
        ValidatorType = type;
    }
}

public class GenericValidatorAttribute<T> : Attribute
{
    public Type ValidatorType { get; }

    public GenericValidatorAttribute()
    {
        ValidatorType = typeof(T);
    }
}

// Why useful? Constraints!
