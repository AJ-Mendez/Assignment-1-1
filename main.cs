using System;

    class Program
    {
        static void Main(string[] args) {
            // Prompt the user for input
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your birthdate (MM/DD/YYYY): ");
            string birthdate = Console.ReadLine();

            Console.Write("Enter your work phone number (XXX-XXX-XXXX): ");
            string workPhone = Console.ReadLine();

            Console.Write("Enter your cell phone number (XXX-XXX-XXXX): ");
            string cellPhone = Console.ReadLine();

            // Display the formatted information
            Console.WriteLine("\nPersonal Information:");
            Console.WriteLine(fullName);
            Console.WriteLine(birthdate);
            Console.WriteLine($"work {workPhone}");
            Console.WriteLine($"cell {cellPhone}");

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }