namespace Task_2;


public class Circle
{
    // Declare a constant variable PI
    public const double PI = 3.14;

    // Method to calculate  area of a circle
    public double Area(double radius)
    {
        return PI * radius * radius;
    }

    // Method to calculate perimeter of a circle
    public double Perimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an object of Circle class
        Circle circle = new Circle();

        // Printing the area
        Console.WriteLine("Area: " + circle.Area(5));

        // Printing the perimeter
        Console.WriteLine("Perimeter: " + circle.Perimeter(5));

        // Cannot modify PI because it is a constant
        // Circle.PI = 3.14159; // Compilation error
    }
}