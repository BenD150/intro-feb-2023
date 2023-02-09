namespace Banking.Domain
{


    public enum LoyaltyLevel { Standard, Gold };

    public class BankAccount
    {
        // Class level variables prefixed with an _
        private decimal _balance = 5000M; // State - "Fields" variable
        public LoyaltyLevel Level; // A public field
        public BankAccount()
        {
        }

        public void Deposit(decimal amountToDeposit)
        {
            decimal bonus = 0;
            if (Level == LoyaltyLevel.Gold)
            {
                bonus = amountToDeposit  * .10M;    
            }

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