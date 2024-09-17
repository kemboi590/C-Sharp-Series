class Program
{
    class Person 
{
    public string Name {get; set;}
    public int Age {get; set;}

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    static void Main()
    {
        Person person1 = new Person("Kemboi", 24);
        Person person2 = person1; // Reference type, both variables point to the same object which is person1

        Console.WriteLine("Reference Type: Class");
        Console.WriteLine($"Person 1: {person1.Name}, Age: {person1.Age}");
        Console.WriteLine($"Person 2: {person2.Name}, Age: {person2.Age}");

        // modifying person2 will also modify person1 because they reference the same object in memory
        person2.Name = "John";
        Console.WriteLine("\nAfter modifying person2:");
        Console.WriteLine($"Person 1: {person1.Name}, Age: {person1.Age}");
        Console.WriteLine($"Person 2: {person2.Name}, Age: {person2.Age}");


        // reference types in Array
        int[] numbers1 = {1,2,3,4,5};
        int[] numbers2 = numbers1; // both variables point to the same array in memory

        Console.WriteLine("\nReference Type: Array");
        Console.WriteLine("numbers1: " + string.Join(", ", numbers1)); 
        Console.WriteLine("numbers2: " + string.Join(", ", numbers2));

        // modifying numbers2 will also modify numbers1 because they reference the same array in memory
        numbers2[0] = 13;
        Console.WriteLine("\nAfter modifying numbers2:");
        Console.WriteLine("numbers1: " + string.Join(", ", numbers1));
        Console.WriteLine("numbers2: " + string.Join(", ", numbers2));

        // string referrence type (immutable reference type)
        string str1 = "Hello";
        string str2 = str1; // both variables point to the same string in memory

        Console.WriteLine("\nReference Type: String");
        Console.WriteLine($"str1: {str1}");
        Console.WriteLine($"str2: {str2}");

        // modifying str2 will not affect str1 because strings are immutable
        str2 = "World";
        Console.WriteLine("\nAfter modifying str2:");
        Console.WriteLine($"str1: {str1}");
        Console.WriteLine($"str2: {str2}");
    }
}

}
