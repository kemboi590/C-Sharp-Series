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
        var studentNamesQuery = from student in students
                                select student.Name;

        Console.WriteLine("Student Names (Query Syntax):");
        foreach (var name in studentNamesQuery)
        {
            Console.WriteLine(name);
        }

        // Method Syntax
        var studenNamesMethod = students.Select(Student => Student.Name);
        Console.WriteLine("\nStudent Names (Method Syntax):");

        foreach (var name in studenNamesMethod)
        {
            Console.WriteLine(name);
        }

    }
}