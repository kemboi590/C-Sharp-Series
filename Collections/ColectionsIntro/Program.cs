// Indexable collections

//  List<T> is a generic collection that is indexable

List<string> salmons = ["chinook", "coho", "pink", "sockeye"];

// iterate over the list
// foreach (var salmon in salmons)
// {
//     Console.WriteLine(salmon + " ");
// }



// remove an item from the list
salmons.Remove("coho");

// iterate over the list
// for (var index = 0; index < salmons.Count; index++)
// {
//     // Console.WriteLine(salmons[index] + " ");
//     // console an index and value
//     Console.WriteLine($"Index: {index}, Value: {salmons[index]}");
// }



// add an item to the list
salmons.Add("atlantic");

// iterate over the list
// foreach (var salmon in salmons)
// {
//     Console.WriteLine(salmon + " ");
// }


List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

// remove odd numbers
// for (var index = numbers.Count - 1; index >= 0; index--)
// {
//     if (numbers[index] % 2 == 1)
//     {
//         numbers.RemoveAt(index);
//     }
//     // lamda expression
//     numbers.ForEach(
//         number => Console.Write(number + " "));
// }


// Define a class to be used in the list
var theGalaxies = new List<Galaxy>
    {
        new () {Name = "Tadpole", MegaLightYears = 400},
        new () {Name = "Pinwheel", MegaLightYears = 25},
        new () {Name = "Milky Way", MegaLightYears = 0},
        new () {Name = "Andromeda", MegaLightYears = 3}
    };

// foreach(Galaxy theGalaxy in theGalaxies)
// {
//     Console.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears);
// }


public class Galaxy
{
    public required string Name { get; set; }
    public int MegaLightYears { get; set; }
}

// key Value Pairs collections

// class
public class Element
{
    public string Symbol { get; set; }
    public string Name { get; set; }
    public int AtomicNumber { get; set; }
}

