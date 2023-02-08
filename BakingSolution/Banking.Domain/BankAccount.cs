namespace Banking.Domain
{
    public class BankAccount
    {
        // Class level variables prefixed with an _
        private decimal _balance = 5000M; // State - "Fields" variable
        public BankAccount()
        {
        }

        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
            
        }

        public decimal GetBalance()
        {
            return _balance; 
        }
    }
}