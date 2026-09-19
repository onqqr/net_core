using project_test_console.lesson1.Homework8;

namespace project_test_console;

public class BankCard : IPaymentProcessor 
{
    public double ProcessPayment(double amount) 
    {
        Console.WriteLine("payment by bank card");
        return amount;
    }
}