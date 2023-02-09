namespace Banking.UnitTests.BonusCalculations;

// 1. Deposits under the cutoff amount get no bonus (5000)
public class StandardBonusCalculatorTests
{
    [Fact]  
    public void UnderCutoffGetNoBonus()
    {
        ICanCalculateAccountBonuses calculator = new StandardBonusCalculator();

        var bonus = calculator.GetDepositBonusFor(4999.99M, 100);

        Assert.Equal(0, bonus);

    }

    [Fact]
    public void AtCutoffGetsBonus()
    {
        ICanCalculateAccountBonuses calculator = new StandardBonusCalculator();

        var bonus = calculator.GetDepositBonusFor(5000M, 100);

        Assert.Equal(10, bonus);

    }

    // 2. Deposits with 5000+ during Business Hours get a bonus

    // 3. Deposits with 5000+ outside of Business Hours get no bonus
}

