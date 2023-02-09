namespace Banking.Domain;

public class StandardBonusCalculator : ICanCalculateAccountBonuses
{
    public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
    {
        return EligibleForBonus(balance) ? amountToDeposit * 0.10M : 0;
    }

    private static bool EligibleForBonus(decimal balance)
    {
        return balance >= 5000M;
    }
}
