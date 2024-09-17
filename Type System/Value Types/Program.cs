byte smallNumber = 255;
Console.WriteLine($"Small number: {smallNumber}");

// Byte range: 0 to 255
Console.WriteLine($"Byte range: {byte.MinValue} to {byte.MaxValue}");

// Try to go beyond the maximum value (overflow)
// try
// {
//     byte overflowByte = (byte)(smallNumber + 1);
//     // casting is required to avoid compile-time error
//     Console.WriteLine($"Overflow byte: {overflowByte}");
// }
// catch (Exception e)
// {
//     Console.WriteLine($"Overflow exception: {e}");
// }





// short

Console.WriteLine($"Short range: {short.MinValue} to {short.MaxValue}");



// int
Console.WriteLine($"Int range: {int.MinValue} to {int.MaxValue}");


// long
Console.WriteLine($"Long range: {long.MinValue} to {long.MaxValue}");


// unsigned types (no negative values)
// ushort

Console.WriteLine($"UShort range: {ushort.MinValue} to {ushort.MaxValue}");

// uint

Console.WriteLine($"UInt range: {uint.MinValue} to {uint.MaxValue}");

// ulong

Console.WriteLine($"ULong range: {ulong.MinValue} to {ulong.MaxValue}");



// Floating Types
/*
A float is a single-precision 32-bit data type.
It is used for floating-point numbers.
*/
float floatNumber = 3.14f; //f or F suffix is required
Console.WriteLine($"Float number: {floatNumber}");

Console.WriteLine($"Float range: {float.MinValue} to {float.MaxValue}");

// double
/*
A double is a double-precision 64-bit data type.
It has a larger range and precision than float.
*/
Console.WriteLine($"Double range: {double.MinValue} to {double.MaxValue}");

// decimal
/*
A decimal is a 128-bit data type suitable for financial and monetary calculations.
It has a higher precision than float and double.
*/
Console.WriteLine($"Decimal range: {decimal.MinValue} to {decimal.MaxValue}");


// precision Demonstration
float floatPrecision = 1f / 3f;
double doublePrecision = 1.0 / 3.0;
decimal decimalPrecision = 1.0m / 3.0m;

Console.WriteLine($"Float precision: {floatPrecision}");
Console.WriteLine($"Double precision: {doublePrecision}");
Console.WriteLine($"Decimal precision: {decimalPrecision}");


// char
/*
Notes:
Char is a single 16-bit Unicode character. It can hold a single character.
*/

char letter = 'A';
Console.WriteLine($"Char: {letter}");