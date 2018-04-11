using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace For_Loops
{
    public class Exercise23
    {
        // Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....].
        public void Start()
        {
            double sum = 1, x, t = 1;
            int terms;
            Console.WriteLine("This program will display the sum of the series (1+x+x^2/2!+x^3/3!+..)");
            Console.WriteLine("======================================================================");
            Console.WriteLine("Input the value of x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the number of terms: ");
            terms = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < terms; i++)
            {
                t = t * x / (float)i;
                sum = sum + t;
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The number of terms is {terms}");
            Console.WriteLine($"The value of x = {x}");
        }
    }
}