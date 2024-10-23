using E_Commerce;

public class Program
{
    public static void Main(string[] args)
    {
        IPaymentProcessor creditCardPayment = new CreditCardPayment();
        creditCardPayment.ProcessPayment(100.00m);
        Console.WriteLine(creditCardPayment.GetPaymentStatus(1));

        IPaymentProcessor paypalPayment = new PayPalPayment();
        paypalPayment.ProcessPayment(100.00m);
        Console.WriteLine(paypalPayment.GetPaymentStatus(2));
    }
}

/*
Explanation:
IPaymentProcessor Interface: 
This defines two methods, ProcessPayment and GetPaymentStatus, that any class implementing this interface must provide. It abstracts the functionality of different payment processors.

CreditCardPayment and PayPalPayment Classes: 
These classes implement the IPaymentProcessor interface, providing their own versions of how a payment is processed and how the payment status is retrieved.


*/