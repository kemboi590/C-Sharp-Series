    namespace  CarNamespace
    {
      public class Car
      {
          // properties of a Car (attributes)
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor to initialize the properties of a Car
         public Car(string make, string model, int year) // constructor is used to initialize the properties of a class
         {
            Make = make;
            Model = model;
            Year = year;
         }

        //  methods of a Car class (behavior)
        public void DisplayInfo() 
        {
            Console.WriteLine($"Car Info: Make: {Make}, Model: {Model}, Year: {Year}");
        }

        // start the car method
        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting....");
        }

        // stop the car method
        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} has stopped.");
        }
      }



    class Program
    {
        static void Main()
        {
            // create an object of the car class
            Car myCar = new Car("Toyota", "Corolla", 2020);

            // accessing the properties of the car object
            myCar.DisplayInfo();
            myCar.Start();
            myCar.Stop();

            // create another object of the car class
            Car anotherCar = new Car("Honda", "Civic", 2021);

            // accessing the properties of the car object
            anotherCar.DisplayInfo();

         
        }
    }
}

// Notes:
/*
1. A class is a blueprint for creating objects. An object is an instance of a class.
2. A class can have properties (attributes) i.e Make, Model, Year and methods (behavior) i.e DisplayInfo, Start, Stop.
3. A constructor is a special method that is used to initialize the properties of a class. It has the same name as the class.
4. Properties can be accessed using the {get; set;} syntax. 
5. new keyword is used to create an object of a class. i.e myCar, anotherCar.
6. Calling a method of a class is done using the object name followed by a dot and the method name. i.e myCar.DisplayInfo(), myCar.Start(), myCar.Stop().
*/