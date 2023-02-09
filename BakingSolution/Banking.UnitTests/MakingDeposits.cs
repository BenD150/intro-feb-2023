namespace Banking.UnitTests;
    public class MakingDeposits
    {

    [Fact]  
    public void DepositingMoneyIncreasesBalance()
    {

        // Given
        var account = new BankAccount(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance(); // I know the balance is 5000, but what if the business rule changes down the line? We are only testing one thing at a timw!!!
        var amountToDeposit = 100M;

        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());  
    }

    }
