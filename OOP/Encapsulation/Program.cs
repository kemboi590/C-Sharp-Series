//Encapsulation

public class BankAccount
{
    private decimal balance;
    public decimal Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance; // is i use balance = initialBalance; it will give me an error because balance is private
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000);
        account.Deposit(500);  // 1000 + 500 = 1500
        Console.WriteLine($"Current Balance: {account.Balance}");

        account.Withdraw(200); // 1500 - 200 = 1300
        Console.WriteLine($"Current Balance: {account.Balance}");
    }
}

/*
NOTES:

Encapsulation is the concept of wrapping the data (variables) and code acting on the data (methods) together as a single unit. It restricts direct access to some of the object's components and allows access to them only through the object's methods.
- In C#, encapsulation is achieved using access modifiers like private, protected, internal, and public.
- The private access modifier restricts access to the members of the class itself.
- The public access modifier allows access to the members of the class from outside the class.
- The protected access modifier allows access to the members of the class from derived classes.
- The internal access modifier allows access to the members of the class from the same assembly.
- The protected internal access modifier allows access to the members of the class from the same assembly or from derived classes.
- Encapsulation helps in data hiding, which is a key concept in object-oriented programming. It helps in maintaining the integrity of the data by preventing unauthorized access and modification.
*/