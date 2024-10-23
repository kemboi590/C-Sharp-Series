
using DataRepository;

public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // create a repository for customers
        IRepoitory<Customer> customerRepository = new Repository<Customer>();
        customerRepository.Add(new Customer { Id = 1, Name = "John Doe" });
        customerRepository.Add(new Customer { Id = 2, Name = "Jane Doe" });

        // fetch all customers
        var customers = customerRepository.GetAll();
        Console.WriteLine("Customers:");
        foreach(var customer in customers)
        {
            Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
        }

        // create a repository for orders
        IRepoitory<Order> orderRepository = new Repository<Order>();
        orderRepository.Add(new Order { Id = 1, ProductName = "Laptop" });
        orderRepository.Add(new Order { Id = 2, ProductName = "Smartphone" });

        // fetch all orders
        var orders = orderRepository.GetAll();
        Console.WriteLine("Orders:");
        foreach(var order in orders)
        {
            Console.WriteLine($"Id: {order.Id}, Product Name: {order.ProductName}");
        }

    }

}

