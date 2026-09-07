namespace project_test_console.Homework8;

public class PayPal : IPaymentProcessor {
    public double ProcessPayment(double amount) {
        Console.WriteLine("payment by paypal");
        return amount;
    }
}