namespace CSharpSyntax;

public class CreatingAndInitializingTypes
{
    [Fact]
    public void UsingLiteralsToCreateInstancesOfTypes()
    {
        // local variables -- variables that are declared inside a method, or property.
        string myName = "Jeff"; // Initializing
        char mi = 'M';

        bool isVendor = true;
        // delete me
        int myAge = 53;
        bool isLegalAgeToDrink = myAge >= 21;

        Taco food = new Taco();
        Assert.Equal("Jeff", myName);
        Assert.Equal(53, myAge);
    }

    // C# is a statically typed language. VARIABLES CANNOT CHANGE THEIR TYPE, EVER! An integer will die as an integer
    [Fact]
    public void ImplicitlyTypedLocalVariables()
    {
        // var can be used for local variables ONLY, and you MUST initialize the variable
        var myAge = 21;

        var myName = "Jeff";

        var favoriteFood = new Taco();

    }
}

public class Taco { }