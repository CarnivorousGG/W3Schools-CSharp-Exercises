using System;
using System.Threading;

namespace For_Loops
{
    public class Exercise3
    {
        // Write a program in C# Sharp to display n terms of natural number and their sum.
        public void Start()
        {
            int n, sum = 0;

            Console.WriteLine("This program will display 'n' natural numbers in terms of user input and their sum.");
            Thread.Sleep(500);
            Console.WriteLine("Please, enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(700);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of natural numbers up to {n} is {sum}");
        }
    }
}