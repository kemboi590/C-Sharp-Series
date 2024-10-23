using System;

namespace E_Commerce;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
    string GetPaymentStatus(int paymentId);

}
