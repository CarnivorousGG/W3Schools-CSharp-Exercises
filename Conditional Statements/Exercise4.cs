using System;

namespace Conditional_Statements
{
//  4. Write a C# Sharp program to find whether a given year is a leap year or not.
    public class Exercise4
    {
        public void Start()
        {
            Console.WriteLine("This program will determine if the year is a leap year or not");
            Console.WriteLine("------------------------");
            Console.WriteLine("Please, enter an year: ");
            var year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
                Console.WriteLine($"{year} is a leap year");
            else if (year % 100 == 0)
                Console.WriteLine($"{year} is not a leap year");
            else if (year % 4 == 0)
                Console.WriteLine($"{year} is a leap year");
            else
                Console.WriteLine($"{year} is not a leap year");
        }
    }
}