//Inheritance
public class Vehicle
{
    public string? Make { get; set; }
    public string? Model { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped");
    }

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }
}

public class Car : Vehicle
{
    public int NumberodDoors { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("Accelerating");
    }

    public Car(string make, string model, int numberOfDoors) : base(make, model)
    {
        NumberodDoors = numberOfDoors;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Corolla", 4);
        Console.WriteLine($"Car Make: {car.Make}");
        Console.WriteLine($"Car Model: {car.Model}");
        Console.WriteLine($"Number of Doors: {car.NumberodDoors}");
        car.StartEngine();
        car.Accelerate();
        car.StopEngine();
    }
}

/*
NOTES:
- Inheritance is the concept of creating a new class that inherits the properties and methods of an existing class. The new class is called a derived class, and the existing class is called a base class.
- In C#, inheritance is achieved using the colon (:) symbol followed by the base class name.
- The derived class can access the public and protected members of the base class.
- The base class constructor is called using the base keyword in the derived class constructor.
- Inheritance allows code reuse and promotes the concept of code organization and hierarchy.
*/