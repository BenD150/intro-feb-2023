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

        Assert.Equal("Old Enough", message);
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

        Assert.StartsWith("1, 2, 3, 4", message.ToString());
    }

    [Fact]
    public void MoreAboutStrings()
    {
        var name = "Bob"; var age = 33; var message = "The name is " + name + " and the age is " + age + ".";
        var message2 = string.Format("The name is {0} and the age is {1} (again, name: {0})", name, age);
        var pay = 120_000.00M;
        var m3 = $"{name} makes {pay:c} a year";
    }


    [Fact]
    public void DoingConversionsOnTypes()
    {

        string myPay = "1000.83";
        

        if (decimal.TryParse(myPay, out decimal payAsNumber))
        {
            // Assert.Equal(10_0000.83M, payAsNumber);
        } else
        {
           // Assert.True(false); // will automatically cause an error
        }

        var birthdate = DateTime.Parse("04/20/1969");
        Assert.Equal(4, birthdate.Month);
        Assert.Equal(20, birthdate.Day);
        Assert.Equal(1969, birthdate.Year);
            

    }

}

public class Taco { }