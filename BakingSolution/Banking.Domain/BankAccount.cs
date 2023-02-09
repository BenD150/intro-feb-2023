namespace Banking.Domain
{
    public class BankAccount
    {
        // Class level variables prefixed with an _
        private decimal _balance = 5000M; // State - "Fields" variable
        private ICanCalculateAccountBonuses _bonusCalculator;

        public BankAccount(ICanCalculateAccountBonuses bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }
        
        // Constructors are for REQUIRED DEPENDENCIES when creating a class.
        public BankAccount(ICanCalculateAccountBonuses bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }

        public void Deposit(decimal amountToDeposit)
        {
            // When you don't know what to do, write the code you wish you had!
            // It's not gonna work, but it may get you on the right track. Eventually you'll have to write it
            decimal bonus = _bonusCalculator.GetDepositBonusFor(_balance, amountToDeposit);
            _balance += amountToDeposit + bonus;

        }

        public decimal GetBalance()
        {
            return _balance; 
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (NotOverdraft(amountToWithdraw))
            {
                _balance -= amountToWithdraw;    
            } else
            {
                throw new AccountOverdraftException();
            }
        }

        // private helper method -- "never type private, always refactor to it"
        private bool NotOverdraft(decimal amountToWithdraw)
        {
            return _balance >= amountToWithdraw;
        }
    }
}