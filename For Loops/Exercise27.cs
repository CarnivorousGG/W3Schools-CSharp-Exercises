using System;

namespace For_Loops
{
    public class Exercise27
    {
        //  Write a C# Sharp program to check whether a given number is perfect number or not.
        public void Start()
        {
            int n, sum;
            Console.WriteLine("This program will check if a given number is perfect or not");
            Console.WriteLine("Please, enter the number: ");
            n = Int32.Parse(Console.ReadLine());
            sum = 0;

            Console.Write("The positive divisor: ");
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    sum = sum + i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The sum is of the divisors is: {sum}");

            if (sum.Equals(n))
            {
                Console.WriteLine("The number is perfect.");
            }
            else
            {
                Console.WriteLine("The number is not perfect.");
            }
        }
    }
}