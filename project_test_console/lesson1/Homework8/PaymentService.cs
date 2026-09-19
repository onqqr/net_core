using project_test_console.lesson1.Homework8;

namespace project_test_console;

public class PaymentService 
{
    private IPaymentProcessor _processor;
    public PaymentService(IPaymentProcessor paymentProcessor) 
    {
        this._processor = paymentProcessor;
    }

    public void Pay(double amount) 
    {
        _processor.ProcessPayment(amount);
    }
}