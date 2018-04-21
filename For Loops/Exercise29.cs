using System;

namespace For_Loops
{
    public class Exercise29
    {

        // Write a C# Sharp program to check whether a given number is an Armstrong number or not.
        public void Start()
        {
            int number, remainder, sum = 0;
            Console.WriteLine("This program will check whether a given number is an Armstrong number or not");
            Console.WriteLine("Enter the number: ");
            number = Int32.Parse(Console.ReadLine());

            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }
            if (sum.Equals(number))
            {
                Console.WriteLine($"{number} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number");
              
            }
        }
    }
}