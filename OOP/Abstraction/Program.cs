public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Shape circle = new Circle(7);
        Console.WriteLine($"Circle Area: {circle.GetArea()}");

        Shape rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
    }
}

/*
NOTES

Abstraction is the concept of hiding the implementation details and showing only the functionality to the user. In C#, abstraction is achieved using abstract classes and interfaces.
- abstract classes cannot be instantiated, but they can be inherited.i.e Shape class is an abstract class.
- abstract methods do not have a body, they are implemented in the derived class.i.e GetArea() method is an abstract method.
- interfaces are similar to abstract classes, but they cannot have fields and constructors. They only have properties, methods, and events.
*/