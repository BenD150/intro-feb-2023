namespace Banking.UnitTests;

public class NewAccounts
{

    // BR #1: Setting this up before we even write any code
    [Fact]  
    public void NewAccountsHaveTheCorrectOpeningBalance()
    {
        // Given I have a brand new bank account
        var account = new BankAccount(new Mock<ICanCalculateAccountBonuses>().Object);

        // When I ask that account for its balance
        decimal openingBalance = account.GetBalance();

        // then it has a balance of $5,000.00
        Assert.Equal(5000M, openingBalance);
    }



}

