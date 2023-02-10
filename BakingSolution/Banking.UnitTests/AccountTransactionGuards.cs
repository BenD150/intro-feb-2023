using Banking.Domain;

namespace Banking.UnitTests;

public class AccountTransactionsGuards
{
// Step 2: Write another test that demonstrates how it SHOULD work if the defect is fixed. It should fail.
    [Fact]
    public void NegativeNumbersNotAllowed()
    {
        var stubbedBonusCalculator = new Mock<ICanCalculateAccountBonuses>();
        var account = new BankAccount(stubbedBonusCalculator.Object);
        var openingBalance = account.GetBalance();
        Assert.Throws<NoNegativeNumbersException>(() => account.Deposit(-1000)); Assert.Equal(openingBalance, account.GetBalance());
    }
}