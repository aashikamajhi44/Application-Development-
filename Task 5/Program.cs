namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        // Create a DateTime variable for birthdate
        DateTime birthDate = new DateTime(2008, 3, 23);

        // Get the current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate the difference between current date and birthdate
        TimeSpan age = currentDate - birthDate;

        // Convert the total days into years
        int ageInYears = (int)(age.TotalDays / 365.25);

        // Add 10 days to the birthdate
        DateTime after10Days = birthDate.AddDays(10);

        // Print the birthdate
        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());

        // Print the current date and time
        Console.WriteLine("Current Date: " + currentDate);

        // Print the age
        Console.WriteLine("Age: " + ageInYears + " years");

        // Print the date after adding 10 days
        Console.WriteLine("Birthdate after 10 days: " + after10Days.ToShortDateString());
    }
}