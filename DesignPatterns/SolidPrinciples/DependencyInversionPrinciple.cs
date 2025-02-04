namespace DesignPatterns.SolidPrinciples;

/// <summary>
/// High-level modules should not depend on low-level modules. Both should depend on abstractions.
/// </summary>

public class CreditCardProcessor
{
    public void ProcessPayment(decimal amount) => throw new NotImplementedException();
}

class Order
{
    public void Checkout(decimal amount)
    {
        CreditCardProcessor processor = new CreditCardProcessor();
        processor.ProcessPayment(amount);
    }
}

// The Order class violates the Dependency Inversion Principle, because it depends on the CreditCardProcessor class directly.

// The refactored code below uses dependency injection to pass the CreditCardProcessor object into the Order class:

public class CreditCardProcessorGood : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) => throw new NotImplementedException();
}

public class DebitCardProcessorGood : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) => throw new NotImplementedException();
}

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class OrderGood(IPaymentProcessor processor)
{
    public void Checkout(decimal amount)
    {
        processor.ProcessPayment(amount);
    }
}