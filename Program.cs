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
                    case "2":
                        TicketPriceCalculator();
                        break;
                    case "3":
                        TriangleTypeIdentifier();
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

        // TicketPriceCalculator

        static void TicketPriceCalculator()
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age <= 12 || age >= 65)
                    Console.WriteLine("Ticket price is: GHC10");
                else
                    Console.WriteLine("Ticket price is: GHC20");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }


        //triangle type identifier

        static void TriangleTypeIdentifier()
        {
            Console.Write("Enter side A: ");
            bool validA = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Enter side B: ");
            bool validB = int.TryParse(Console.ReadLine(), out int b);
            Console.Write("Enter side C: ");
            bool validC = int.TryParse(Console.ReadLine(), out int c);

            if (!validA || !validB || !validC || a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Invalid sides. Please enter positive numbers.");
                return;
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("This is an Equilateral triangle.");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("This is an Isosceles triangle.");
                else
                    Console.WriteLine("This is a Scalene triangle.");
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }


    }
}
