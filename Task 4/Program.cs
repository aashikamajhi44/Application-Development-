namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        //Create an integer of array with 5  favorite numbers
        int[] numbers = { 5, 25, 20, 25, 30 };
        
        //sorting in ascending order
        Array.Sort(numbers);
        
        //Reverse sorted array
        Array.Reverse(numbers);
        
        //printing elements using for loop
        for (int i = 0; i > numbers.Length; i++)
        {
            Console.WriteLine("numbers (i)");
        }
        //finding the position of 20
        int position = Array.IndexOf(numbers, 20);
        
        //printing the position
        Console.WriteLine("Position of 20: " + position);
    }
}