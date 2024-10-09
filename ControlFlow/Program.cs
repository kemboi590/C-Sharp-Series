using ControlFlow;

/*
Control Flow is the order in which the program executes the code. It is the sequence in which the program executes the code.
Control flow in C# refers to the order in which individual statements, instructions, or function calls are executed or evaluated within a program. C# provides several control flow statements that allow you to dictate how your program progresses.
We are going to cover
1. if-else Statement - 
2. if-else-if-else ladder
3. switch statement
4. for loop
5. while loop
6. do-while loop
7. foreach loop
*/

// if-else Statement

int number = 11;

if( number % 2 == 0)
{
    Console.WriteLine("Number is Even");
} else
{
    Console.WriteLine("Number is Odd");
}

// if-else-if-else ladder

int age = 60;
if (age < 18)
{
    Console.WriteLine("You are a minor");
}
else if (age >= 18 && age < 60)
{
    Console.WriteLine("You are an adult");
}
else
{
    Console.WriteLine("You are a senior citizen");
}

// switch statement - It is used to select one of many code blocks to be executed

// int day = 3;
// allow user input of the day, ie a user to input a number between 1 and 7



// Console.Write("Enter a number between 1 and 7: ");
// int day = Convert.ToInt32(Console.ReadLine());

// switch(day)
// {
//     case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     case 4:

//         Console.WriteLine("Thursday");
//         break;
//     case 5:
//         Console.WriteLine("Friday");
//         break;
//     case 6:
//         Console.WriteLine("Saturday");
//         break;
//     case 7:
//         Console.WriteLine("Sunday");
//         break;
//     default:
//         Console.WriteLine("Invalid day, please enter a number between 1 and 7");
//         break;
// }



// for loop - It is used to iterate a part of the program several times

/*
for (int i = 0; i <5 ; i++)
{
    Console.WriteLine("Iteration number: " + i);
}
*/

// another example of for loop in C# in real life scenario is to iterate through an array

/*
int[] numbers = {1, 2, 3, 4, 5};

for (int i = 0; i < numbers.Length; i++)
{
    // console valie and index of the array
    Console.WriteLine($"Value at index {i} is {numbers[i]}");
}
*/

// Nested for Loops

// loop for rows
for (int i = 1; i <= 5; i++)
{
    // loop for columns
    for (int j=1; j<=3; j++)
    {
        Console.WriteLine($"{i}, {j}");
    }
    Console.WriteLine();

}


// while loop - It is used to iterate a part of the program several times
/*
int count = 1;

while (count <= 5)
{
    Console.WriteLine("Count is: " + count);
    count++;
    // Console.WriteLine("Count is now: " + count);
}
*/

// do-while loop - It is used to iterate a part of the program several times
/*
int count = 1;
do 
{
    Console.WriteLine("Count is: " + count);
    count++;
}
while (count <= 5);
*/

// foreach loop - It is used to iterate through the items in an array or collection


/*
string[] fruits = {"Apple", "Banana", "Orange", "Mango"};

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

*/



// another example of foreach loop in C# in real life scenario is to iterate through a list of objects

/*

// List<Person> people = new List<Person> // can also be written as var people = new List<Person>
var people = new List<Person>
{
    new Person { Name = "John", Age = 25 },
    new Person { Name = "Jane", Age = 30 },
    new Person { Name = "Doe", Age = 35 }
};

foreach (Person person in people)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

*/


/*
A coding challenge for me after learning control flow in C# is to 
1. write a program that takes in a number from the user and checks if the number is a prime number or not.
i.e if the user enters 5, the program should output "5 is a prime number"
2. write a program that takes in a number from the user and checks if the number is a palindrome or not.
i.e if the user enters 121, the program should output "121 is a palindrome"
// a palindrome is a number that reads the same forwards as backwards other examples of palindrome numbers are 121, 1221, 12321, 1234321
// foreach challenge
3. write a program that takes in a list of numbers from the user and calculates the sum of the numbers.
i.e if the user enters 1, 2, 3, 4, 5, the program should output 15
*/




