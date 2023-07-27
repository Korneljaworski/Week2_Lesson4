public class Program
{
    private static void Main(string[] args)
    {
        // Task 1
        string firstName, lastName, pesel, employeeNumber;
        int age;
        char sex;

        // Task 2
        char var1 = 'a', var2 = 'b', var3 = 'c';
        Console.WriteLine($"{var3}, {var2}, {var1}");

        // Task 3
        double width = 2, length = 2.5, diagonal;
        diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
        Console.WriteLine($"Diagonal: {diagonal}");

        // Task 4
        string text = "Szkoła Dotneta";
        int numberInt = 10;
        double numberDouble = 12.5;

        // Task 5
        Console.WriteLine("Please enter Your first name:");
        firstName = Console.ReadLine();

        Console.WriteLine("Please enter Your last name:");
        lastName = Console.ReadLine();

        Console.WriteLine("Please enter Your phone number:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Please enter Your e-mail:");
        string email = Console.ReadLine();

        Console.WriteLine("Please enter Your height:");
        double height;
        bool result = double.TryParse(Console.ReadLine(), out height);

        Console.WriteLine("Please enter Your weight:");
        double weight;
        bool result2 = double.TryParse(Console.ReadLine(), out weight);

        Console.WriteLine("Please enter Your age:");
        bool result3 = int.TryParse(Console.ReadLine(), out age);

        Console.WriteLine("Please enter Your sex: M or F");
        bool result4 = char.TryParse(Console.ReadLine(), out sex);
    }
}