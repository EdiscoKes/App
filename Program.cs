using System;

namespace MyMiniApps
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an Application:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator();
                        break;
                    
                    case "4":
                        Console.WriteLine("Exiting application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void GradeCalculator()
        {
            Console.Write("Enter your numerical grade (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                if (grade >= 90)
                    Console.WriteLine("Your grade is: A");
                else if (grade >= 80)
                    Console.WriteLine("Your grade is: B");
                else if (grade >= 70)
                    Console.WriteLine("Your grade is: C");
                else if (grade >= 60)
                    Console.WriteLine("Your grade is: D");
                else
                    Console.WriteLine("Your grade is: F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

       
    }
}
