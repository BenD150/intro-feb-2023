using Banking.Domain;

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
        var amount = decimal.Parse(amountInput.Text);
        op(amount);
        UpdateBalanceDisplay();
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