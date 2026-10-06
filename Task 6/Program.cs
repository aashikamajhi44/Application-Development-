namespace Task_6;

class Program
{
    static void Main(string[] args)
    {
        // Create a List containing 3 favorite fruits
        List<string> fruits = new List<string>
        {
            "Apple",
            "Dragon Fruit",
            "Pear"
        };

        // Add a new fruit to the list
        fruits.Add("Orange");

        // Removing one fruit from the list
        fruits.Remove("Apple");

        // Printing all fruits using foreach loop
        Console.WriteLine("Fruits:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary with fruit IDs and fruit names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Dragon Fruit" },
            { 3, "Pear" }
        };

        // Adding a new entry to the dictionary
        fruitDictionary.Add(4, "Orange");

        // Printing all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine("ID: " + item.Key + ", Fruit: " + item.Value);
        }
    }
}