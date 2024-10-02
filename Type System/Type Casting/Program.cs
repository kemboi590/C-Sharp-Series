// Type Casting
using Type_Casting;

class Program
{
    static void Main()
    {
        // type casting is the process of converting one type of data to another type
        // There is two types of casting:
        // 1. Implicit casting	
        // 2. Explicit casting

        // Implicit casting - Converting a smaller type to a larger type size
        // byte -> short  -> int -> long -> float -> double

        int num1 = 100;
        double doubleNum = num1; // automatically converts the int to a double

        Console.WriteLine("Implicit-> Converted duble: " + doubleNum);

        // Explicit casting - Converting a larger type to a smaller size type
        // double -> float -> long -> int -> short -> byte

        double pi = 3.14159;
        int intPi = (int)pi;
        Console.WriteLine($"Explicit-> Converted int: {intPi}");

        // Type casting with 'as' keyword
        Animal animal = new Dog(); // implicit casting- dog is a subclass of animal
        Dog? dog = animal as Dog; //safe cast - if the cast is not possible, 'as' returns null

        if (dog != null)
        {
            Console.WriteLine("Successfully Casted Animal to Dog using 'as' keyword");
        }

        // Type Checking with 'is' Operator
        Animal animal2 = new Cat();
        Console.WriteLine("Type checking with 'is' Operator");
        if (animal2 is Cat)
        {
            Console.WriteLine("animal2 is a cat");
        }

        if (animal is Dog)
        {
            Console.WriteLine("animal is a Dog");
        }


        // Boxing and unboxing
        // Boxing is the process of converting a value type (like int) to a reference type (object), and unboxing is converting it back.
        // 1. Boxing

        int age = 35;
        object obj = age; // boxing
        Console.WriteLine("Boxing-> Converted int to object: " + obj);

        // unboxing
        int unboxedAge = (int)obj;
        Console.WriteLine("Unboxing-> Converted object to int: " + unboxedAge);


        // Type Conversion with the Convert Class
        // The Convert class is used for converting between types safely, especially for parsing strings to numbers.
        string strNumber = "100";
        // Console.WriteLine(strNumber.GetType());
        int intNumber = Convert.ToInt32(strNumber);
        Console.WriteLine($"Converted string to int: {intNumber.GetType()}");
    }
}