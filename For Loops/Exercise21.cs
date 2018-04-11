using System;
using System.Diagnostics.CodeAnalysis;

namespace For_Loops
{
    public class Exercise21
    {
        // Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]
        public void Start()
        {
            try
            {
                int n, t = 9, sum = 0;
                Console.WriteLine("This program will display the sum of the series [9 + 99 + 999 + 9n amount of times.");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    sum += t;
                    Console.Write($"{t} ");
                    t = t * 10 + 9;
                }
                Console.WriteLine();
                Console.WriteLine($"The sum is: {sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

        }
    }
}