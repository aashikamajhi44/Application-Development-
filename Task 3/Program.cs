namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        //declaring the datatypes
        byte byteValue = 10;
        short shortValue = 10;
        int intValue = 42;
        long longValue = 500L;
        float floatValue = 3.14f;
        double doubleValue = 3.1522;
        decimal decimalValue = 3.152M;
        char charValue = 'A';
        bool boolValue = true;
        
        //converting integer to string
        string intToString = intValue.ToString();
        
        //converting string to double
        double stringToDouble = Convert.ToDouble("3.14");
        
        
        //printing the variables
        Console.WriteLine("byte: " + byteValue);
        Console.WriteLine("short: " + shortValue);
        Console.WriteLine("int: " + intValue);
        Console.WriteLine("long: " + longValue);
        Console.WriteLine("float: " + floatValue);
        Console.WriteLine("double: " + doubleValue);
        Console.WriteLine("decimal: " + decimalValue);
        Console.WriteLine("char: " + charValue);
        Console.WriteLine("bool: " + boolValue);
        Console.WriteLine("intToString: " + intToString);
        Console.WriteLine("stringToDouble: " + stringToDouble);
        
    }
}