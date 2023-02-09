namespace Banking.UnitTests;



public class GoldCustomersGetBonusOnDeposits
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        // Given
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        // When
        account.Deposit(amountToDeposit); // <-- THIS IS THE SYSTEM UNDER TEST
        // Then
        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
    }

}

