namespace Banking.Domain;

// This extends a bank account
public class GoldBankAccount  : BankAccount
{

    // I need to override the regular deposit method for bankaccount
    public override void Deposit(decimal amountToDeposit)
    {
        base.Deposit(amountToDeposit * 1.10M);
    }

}

