
// polymorphism 
public class Animal
{
    public virtual void MakeSound() //virtual keyword allows the method to be overridden in the derived class
    {
        Console.WriteLine("Some sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        // base.MakeSound(); //base keyword is used to call the base class method
        Console.WriteLine("A Dog Barks: Woof Woof!!!"); //override keyword is used to override the base class method
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("A Cat Meows: Meow Meow!!!");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound();

        Dog dog = new Dog();
        dog.MakeSound();

        Cat cat = new Cat();
        cat.MakeSound();
    }
}

/*
NOTES:
Polymorphism is the ability of an object to take on many forms. In C#, polymorphism is achieved using method overriding.
- Method overriding is a feature that allows a subclass to provide a specific implementation of a method that is already provided by its superclass.
- The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
- The override keyword is used to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
*/