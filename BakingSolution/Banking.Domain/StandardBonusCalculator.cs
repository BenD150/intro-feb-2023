namespace Banking.Domain;

public class StandardBonusCalculator : ICanCalculateAccountBonuses
{
    public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
    {
        return 0;
    }
}
