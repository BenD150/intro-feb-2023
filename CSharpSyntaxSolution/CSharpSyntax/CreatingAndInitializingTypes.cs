using System.Text;

namespace CSharpSyntax;

public class CreatingAndInitializingTypes
{
    string thingy = "Bird";

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
    // literal = typed in value
    [Fact]
    public void ImplicitlyTypedLocalVariables()
    {
        // var can be used for local variables ONLY, and you MUST initialize the variable
        // Using var: Can be a little less typing
        var myAge = 21;

        var myName = "Jeff";

        var favoriteFood = new Taco();

        // M does NOT mean million, it means decimal
        var myPay = 25.23M;

        // Option in C# 6, we don't use this much except in special circumstances
        Taco lunch = new();
    }

    [Fact]
    public void CurlyBracesCreateScopes()
    {
        // lunch is local to ImplicitlyTyped method above
        // Assert.IsType<Taco>(lunch);

        // However, it can see class variables
        Assert.IsType<String>(thingy);

        var message = "";
        var age = 22;
        if (age >= 21)
        {
            message = "Old Enough";
        }

        Assert.Equal(message, "Old Enough");
    }

    [Fact]  
    public void MutableStringsWithStringBuilders()
    {
        var message = "";

        foreach(var num in Enumerable.Range(1, 10000))
        {
            // An explosion in the heap with the high number of allocations
            message += num + ", ";
        }

        // Do this instead!
        var message2 = new StringBuilder();

        foreach (var num in Enumerable.Range(1, 10000))
        {
            message2.Append(num.ToString() + ", "); 
        }


    }


}

public class Taco { }