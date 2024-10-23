
using Dictionary;

class Program
{
    private static Dictionary<string, Element> BuildDictionary() =>
    new()
    {
            {"K",
                new (){ Symbol="K", Name="Potassium", AtomicNumber=19}},
            {"Ca",
                new (){ Symbol="Ca", Name="Calcium", AtomicNumber=20}},
            {"Sc",
                new (){ Symbol="Sc", Name="Scandium", AtomicNumber=21}},
            {"Ti",
                new (){ Symbol="Ti", Name="Titanium", AtomicNumber=22}}
    };

    static void Main()
    {
        Dictionary<string, Element> elements = BuildDictionary();

        foreach (KeyValuePair<string, Element> kvp in elements)
        {
            Element theElement = kvp.Value;

            Console.WriteLine("key: " + kvp.Key);
            Console.WriteLine("values: " + theElement.Symbol + " " +
                theElement.Name + " " + theElement.AtomicNumber);
        }
    }
}
