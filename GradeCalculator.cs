using System;

public class GradeCalculator
{
    public void Run()
    {
        Console.Write("Enter a grade (0 - 100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade >= 90 && grade <= 100)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else if (grade >= 0)
                Console.WriteLine("Grade: F");
            else
                Console.WriteLine("Invalid input. Grade must be between 0 and 100.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}
