using System;
public class GradeCalculator
{
    public void Run()
    {
        Console.WriteLine("Enter your grade(0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade >= 90 && grade <= 100)
                Console.WriteLine("Grade: A");

        }
    }
} 

