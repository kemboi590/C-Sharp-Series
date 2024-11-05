class Student
{
    public required string Name { get; set; }
    public int Age { get; set; }
}
 

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20 },
            new Student { Name = "Bob", Age = 22 },
            new Student { Name = "Charlie", Age = 23 }
        };

         // Query Syntax
         var sortedStudentsQuery =  from student in students
                                    orderby student.Age
                                    select student;

         Console.WriteLine("Students sorted by Age (Query Syntax):");
         foreach(var student in sortedStudentsQuery)
         {
              Console.WriteLine($"{student.Name} - Age: {student.Age}");
         }


          // Method Syntax
        var sortedStudentsMethod = students.OrderBy(student => student.Age);

        Console.WriteLine("\nStudents sorted by Age (Method Syntax):");
        foreach (var student in sortedStudentsMethod)
        {
            Console.WriteLine($"{student.Name} - Age: {student.Age}");
        }

    }
}

/*
Notes on LINQ

1.  LINQ A syntax in C# to query various data sources, like collections, XML, and databases. 
    LINQ queries are strongly typed, compile-time checked, and can be integrated into the code in a natural, readable format.

2. Query Syntax vs. Method Syntax:

Query Syntax: SQL-like syntax that is often easier to read.
Method Syntax: Uses lambda expressions with methods like Where, Select, and OrderBy.

3. Deferred Execution: LINQ queries are not executed when defined; they’re executed when iterated, which allows for efficient data handling.

4. Lambda Expressions: Inline functions used in LINQ for creating compact code.


*/