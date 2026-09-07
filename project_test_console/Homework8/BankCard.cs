namespace project_test_console.Homework8;

public class BankCard : IPaymentProcessor {
    public double ProcessPayment(double amount) {
        Console.WriteLine("payment by bank card");
        return amount;
    }
}