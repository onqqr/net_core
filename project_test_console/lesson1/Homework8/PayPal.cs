using project_test_console.lesson1.Homework8;

namespace project_test_console.Homework8;

public class PayPal : IPaymentProcessor {
    public double ProcessPayment(double amount) 
    {
        Console.WriteLine("payment by paypal");
        return amount;
    }
}