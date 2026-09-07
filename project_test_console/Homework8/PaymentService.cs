namespace project_test_console.Homework8;

public class PaymentService {
    private IPaymentProcessor _processor;
    public PaymentService(IPaymentProcessor paymentProcessor) {
        this._processor = paymentProcessor;
    }

    public void Pay(double amount) {
        _processor.ProcessPayment(amount);
    }
}