namespace Banking.Domain
{
    public class BankAccount
    {
        // Class level variables prefixed with an _
        private decimal _balance = 5000M; // State - "Fields" variable
        private ICanCalculateAccountBonuses _bonusCalculator;

        // Constructors are for REQUIRED DEPENDENCIES when creating a class.
        public BankAccount(ICanCalculateAccountBonuses bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }

        public void Deposit(decimal amountToDeposit)
        {
            GuardNoNegativeAmountsForTransactions(amountToDeposit);
            // When you don't know what to do, write the code you wish you had!
            // It's not gonna work, but it may get you on the right track. Eventually you'll have to write it
            decimal bonus = _bonusCalculator.GetDepositBonusFor(_balance, amountToDeposit);
            _balance += amountToDeposit + bonus;

        }

        private static void GuardNoNegativeAmountsForTransactions(decimal amountToDeposit)
        {
            if (amountToDeposit < 0)
            {
                throw new NoNegativeNumbersException();
            }
        }

        public decimal GetBalance()
        {
            return _balance; 
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            GuardNoNegativeAmountsForTransactions(amountToWithdraw);

            if (NotOverdraft(amountToWithdraw))
            {
                _balance -= amountToWithdraw;
                // Write the code you wish you had
                // _notifier.CheckForRequiredNotification(this, amountToWithdraw);

            }
            else
            {
                throw new AccountOverdraftException();
            }
        }

        private static void GuardNoNegativeAmountsForTransactions(decimal amountToWithdraw)
        {
            if (amountToWithdraw < 0)
            {
                throw new NoNegativeNumbersException();
            }
        }

        // private helper method -- "never type private, always refactor to it"
        private bool NotOverdraft(decimal amountToWithdraw)
        {
            return _balance >= amountToWithdraw;
        }
    }
}