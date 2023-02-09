namespace Banking.Domain
{
    public class BankAccount
    {
        // Class level variables prefixed with an _
        private decimal _balance = 5000M; // State - "Fields" variable
        public BankAccount()
        {
        }

        // Adding the virtual keyword to say that this method can be overridden by any class that inherits this 
        public virtual void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
            
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