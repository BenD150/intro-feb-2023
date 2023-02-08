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
    public void OverdraftIsNotAllowedBalanceStaysTheSame()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void CanTakeEntireBalance()
    {
        var account = new BankAccount();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }
}

