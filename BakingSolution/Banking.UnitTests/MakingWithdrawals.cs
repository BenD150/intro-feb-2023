namespace Banking.UnitTests;

public class MakingWithdrawals
{
    [Theory]
    [InlineData(100)]
    [InlineData(183.23)]  
    public void MakingWithdrawalDecreasesBalance(decimal amountToWithdraw)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());  
    }


    [Fact]
    public void CanOverdraft()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}

