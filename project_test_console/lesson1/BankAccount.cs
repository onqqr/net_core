namespace project_test_console.lesson1;

public class BankAccount {
    private string _userName;
    private string _accountNumber;
    private double _balance;
    
    public BankAccount(string userName, string accountNumber, double balance) {
        this._userName = userName;
        this._accountNumber = accountNumber;
        this._balance = balance < 0 ? 0 : balance;
    }

    public void Deposit(double amount) {
        if (amount <= 0) {
            Console.WriteLine("you cannot deposit negative or zero");
            return;
        }
        _balance += amount;
    }

    public void Withdraw(double amount) {
        if (amount <= 0) {
            Console.WriteLine("you cannot withdraw negative or zero");
            return;
        } 
        if (amount > _balance) {
            Console.WriteLine("you cannot withdraw more than your balance");
            return;
        }
        _balance -= amount;
    }
}