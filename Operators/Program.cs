/*
We shall be covering the following Operators in this section:

Arithmetic Operators
Relational/Comparison Operators
Logical Operators
Assignment Operators
Bitwise Operators
Unary Operators
Ternary Operators (Conditional Operator)
*/

// 1. Arithmetic Operators (+, -, *, /, %, ++, --)
 int a = 10;
 int b = 3;

Console.WriteLine("Arithmetic Operators"); 
Console.WriteLine($"Addition: {a} + {b} = {a + b}");
Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
Console.WriteLine($"Division: {a} / {b} = {a / b}");
Console.WriteLine($"Modulus: {a} % {b} = {a % b}");

// 2. Relational/Comparison Operators (==, !=, >, <, >=, <=)
Console.WriteLine("\nRelational/Comparison Operators");
Console.WriteLine($"Equal to: {a} == {b} = {a == b}");
Console.WriteLine($"Not Equal to: {a} != {b} = {a != b}");
Console.WriteLine($"Greater than: {a} > {b} = {a > b}");
Console.WriteLine($"Less than: {a} < {b} = {a < b}");
Console.WriteLine($"Greater than or Equal to: {a} >= {b} = {a >= b}");
Console.WriteLine($"Less than or Equal to: {a} <= {b} = {a <= b}");

// 2. Logical Operators (&&, ||, !)
bool x = true;
bool y = false;

Console.WriteLine("\nLogical Operators");
Console.WriteLine($"AND: {x} && {y} = {x && y}"); // means both x and y should be true
Console.WriteLine($"OR: {x} || {y} = {x || y}"); // means either x or y should be true
Console.WriteLine($"NOT: !{x} = {!x}"); // means opposite of x

// 4. Assignment Operators (=, +=, -=, *=, /=, %=)
int c = 5;

Console.WriteLine("\nAssignment Operators");
c += 3; // c = c + 3
Console.WriteLine($"Addition Assignment: c += 3 = {c}");
c -= 3; // c = c - 3
Console.WriteLine($"Subtraction Assignment: c -= 3 = {c}");
c *= 3; // c = c * 3
Console.WriteLine($"Multiplication Assignment: c *= 3 = {c}");
c /= 3; // c = c / 3
Console.WriteLine($"Division Assignment: c /= 3 = {c}");
c %= 3; // c = c % 3
Console.WriteLine($"Modulus Assignment: c %= 3 = {c}");

// 5. Bitwise Operators (&, |, ^, ~, <<, >>)
int d = 6; // 0110
int e = 3; // 0011

Console.WriteLine("\nBitwise Operators");
Console.WriteLine($"Bitwise AND: {d} & {e} = {d & e}"); // this means 0110 & 0011 = 0010
Console.WriteLine($"Bitwise OR: {d} | {e} = {d | e}"); // this means 0110 | 0011 = 0111
Console.WriteLine($"Bitwise XOR: {d} ^ {e} = {d ^ e}"); // this means 0110 ^ 0011 = 0101
Console.WriteLine($"Bitwise NOT: ~{d} = {~d}"); // this means ~0110 = 1001
Console.WriteLine($"Left Shift: {d} << 1 = {d << 1}"); // this means 0110 << 1 = 1100
Console.WriteLine($"Right Shift: {d} >> 1 = {d >> 1}"); // this means 0110 >> 1 = 0011

// 6. Unary Operators (+, -, ++, --, !)
int f = 5;

Console.WriteLine("\nUnary Operators");
Console.WriteLine($"Unary Plus: +{f} = {+f}");
Console.WriteLine($"Unary Minus: -{f} = {-f}");
Console.WriteLine($"Increment: {f}++ = {f++}"); // this means f = f + 1, output will be 5 because f++ is post increment
Console.WriteLine($"Decrement: {f}-- = {f--}");

// 7. Ternary Operators (Conditional Operator) (condition ? expression1 : expression2)
int age = 17;
string voitingEligibility = age >= 18 ? "Eligible" : "Not Eligible";

Console.WriteLine("\nTernary Operators");
Console.WriteLine($"Age {age} is {voitingEligibility} for voting");