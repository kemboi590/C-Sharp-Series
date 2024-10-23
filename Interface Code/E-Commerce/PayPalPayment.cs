using System;
using System.Security.Cryptography.X509Certificates;

namespace E_Commerce;

public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment for {amount: C}");
    }

    public string GetPaymentStatus(int paymentId)
    {
        return $"PayPal Payment {paymentId} is complete";
    }

}
