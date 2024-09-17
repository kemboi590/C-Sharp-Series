// Nullable types
double? pi = 3.14;
char? letter = 'a';
int? m = 10;
bool? isMale = null; 
int?[] arr = new int?[10]; //array of nullable type
Console.WriteLine($"pi: {pi}, letter: {letter}, m: {m}, isMale: {isMale}, arr[0]: {arr[0]}");

// checking if nullable has a value
int? b = 20;
if(b != null)
{
    Console.WriteLine($"b is {b.Value}");
}
else
{
    Console.WriteLine("b does not have a value");
}

// Coalescing operator- returns left-hand operand if the operand is not null; otherwise it returns the right hand operand
int? c = 20;
int d = c ?? -1;
Console.WriteLine($"d is {d}");

// Usage of var keyword
var i = 5;
Console.WriteLine("i Type: " + i.GetType());

var s = "Hello";
Console.WriteLine("s Type: " + s.GetType());

var NumberArr = new[] { 0, 1, 2 };
Console.WriteLine("NumberArr Type: " + NumberArr.GetType());