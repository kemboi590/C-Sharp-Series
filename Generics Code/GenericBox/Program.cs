using Generics;

public class Program
{
    public static void Main(string[] args)
    {
        Box<string> box = new Box<string>();
        box.Add("Hello, World!");
        System.Console.WriteLine(box.GetItem());

        Box<int> intBox = new Box<int>();
        intBox.Add(42);
        System.Console.WriteLine(intBox.GetItem());

    }
}