namespace Banking.UnitTests;



public class BankAccountDepositsUseTheBonusCalculator
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        // Given
        var stubbedBonusCalculator = new Mock<ICanCalculateAccountBonuses>();
        var account = new BankAccount(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 118.32M;
        stubbedBonusCalculator.Setup(calculator =>
            calculator.GetDepositBonusFor(openingBalance, amountToDeposit)
            ).Returns(42.18M);

        account.Deposit(amountToDeposit);
        Assert.Equal(openingBalance + amountToDeposit + 42.18M, account.GetBalance());
    }
}




