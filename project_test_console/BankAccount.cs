namespace project_test_console;

public class BankAccount {
    private string userName;
    private string accountNumber;
    private double balance;
    
    public BankAccount(string userName, string accountNumber, double balance) {
        this.userName = userName;
        this.accountNumber = accountNumber;
        this.balance = balance < 0 ? 0 : balance;
    }

    public void Deposit(double amount) {
        if (amount <= 0) {
            Console.WriteLine("you cannot deposit negative or zero");
            return;
        }
        balance += amount;
    }

    public void Withdraw(double amount) {
        if (amount <= 0) {
            Console.WriteLine("you cannot withdraw negative or zero");
            return;
        } 
        if (amount > balance) {
            Console.WriteLine("you cannot withdraw more than your balance");
            return;
        }
        balance -= amount;
    }
}