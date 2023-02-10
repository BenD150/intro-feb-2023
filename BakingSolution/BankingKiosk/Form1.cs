using Banking.Domain;
using System.DirectoryServices.ActiveDirectory;

namespace BankingKiosk;

public partial class Form1 : Form
{
    BankAccount _account;
    public Form1()
    {
        InitializeComponent();
        _account = new BankAccount(new StandardBonusCalculator(new StandardBusinessClock(new SystemTime())));
        UpdateBalanceDisplay();
    }

    private void UpdateBalanceDisplay()
    {
        this.Text = $"You have a balance of {_account.GetBalance():c} currently";
    }

    private void depositButton_Click(object sender, EventArgs e)
    {
        DoTransaction(_account.Deposit);

    }

    private void withdrawButton_Click(object sender, EventArgs e)
    {
        DoTransaction(_account.Withdraw); // Named Method ("Method Group")

    }

    // Example of using a delegate
    private void DoTransaction(Action<decimal> op) // If you call me you have to give me a method that returns void and takes a decimal argument
    {
        try
        {
            var amount = decimal.Parse(amountInput.Text);
            op(amount);
            UpdateBalanceDisplay();
        }
        catch (FormatException)
        {
            DisplayTransactionError("Enter a number");
        }
        catch (AccountOverdraftException)
        {
            DisplayTransactionError("You don't have enough money to do that!");
        }
        catch (NoNegativeNumbersException)
        {
            var message = "You Don't Have Enough Money, Get a Job Loser";
            DisplayTransactionError(message);
        }
        finally
        {
            // Run this if there is an error, or if there isn't an error. ALWAYS
            amountInput.SelectAll(); // Select all of the text in the input
            amountInput.Focus(); // Focuses the cursor
        }
        
  
    }

    private static void DisplayTransactionError(string message)
    {
        MessageBox.Show(message, "Error in Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Anonymous function (a method with no name) we call these "Lambdas" in C#
        DoTransaction((amount) => MessageBox.Show("You clicked a button, blah" + amount.ToString()));

        // "Anonymous Delegate" - how we did it until about 2008
        /*
         * DoTransaction (delegate (decimal amount)
         * {
         *  MessageBox.Show("You clicked a button, blah" + amount.ToString()
         *  });
         *  HomoIconicity - code and data structures are represented the same way
         */
    }
}