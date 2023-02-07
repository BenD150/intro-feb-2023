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

    [Fact]
    public void ImplicitlyTypedLocalVariables()
    {

    }
}

public class Taco { }