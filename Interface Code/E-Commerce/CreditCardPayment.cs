using System;

namespace E_Commerce;

public class CreditCardPayment: IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment for {amount: C}");
    }

    public string GetPaymentStatus(int paymentId)
    {
        return $"Credit card Payment {paymentId} is complete";
    }

}
