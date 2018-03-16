using System;

namespace Conditional_Statements
{
//    3. Write a C# Sharp program to check whether a given number is positive or negative.
    public class Exercise3
    {
        public void Start()
        {
            Console.WriteLine("Please enter a number: ");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine($"{num} is a positive number");
            else if (num == 0)
                Console.WriteLine("The number is equal to zero");

            else
                Console.WriteLine($"{num} is a negative number");
        }
    }
}