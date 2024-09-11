namespace C_sharpVariables
{
    class Program
    {
        static void Main()
        {
            // 1. Interger variable (int)
            int age = 24;
            Console.WriteLine("age:" + age);

            // 2. String variable (string)
            string name = "Kemboi";
            Console.WriteLine($"Name: {name}");

            // 3. Float variable (float)
            float height = 5.7f;
            Console.WriteLine($"Height: {height}");

            // 4. Double variable (double)
            double weight = 70.5;
            Console.WriteLine($"Weight: {weight}");

            // 5. Boolean variable (bool)
            bool isMale = true;
            bool isStudent = false;
            Console.WriteLine($"isStudent: {isStudent}");
            Console.WriteLine($"isMale: {isMale}");

            // 6. Char variable (char)
            char grade = 'A';
            Console.WriteLine($"Grade: {grade}");

            // Variable decalaration without initialization
            int num1;   //declaration
            num1 = 10;  //initialization
            Console.WriteLine($"num1: {num1}");


            // variables and calculations
            int a= 10, b= 20, c= 30;
            int sum = a + b + c;
            Console.WriteLine($"Sum: {sum}");

            // Reassigning variables
            int x = 10;
            x = 20;
            Console.WriteLine($"x: {x}");
        }
    }
}