namespace Banking.Domain;

public class StandardBonusCalculator : ICanCalculateAccountBonuses
{
    private IProvideTheBusinessClock _businessClock;
    public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
    {
        return EligibleForBonus(balance) ? amountToDeposit * 0.10M : 0;
    }

    private bool EligibleForBonus(decimal balance)
    {
        // Too much work for the bonus calculator to know the business hours, so we're gonna use another class that is responsible for this 
        return balance >= 5000M && _businessClock.IsDuringBusinessHours();
    }
}
