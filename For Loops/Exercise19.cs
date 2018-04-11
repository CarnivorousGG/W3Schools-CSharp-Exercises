using System;

namespace For_Loops
{
    public class Exercise19
    {
        // Write a program in C# Sharp to display the n terms of harmonic series and their sum.
        public void Start()
        {
            double sum = 0, harmonic = 1;
            int n;
            Console.WriteLine("This program will displayy the n terms of harmonic series and their sum");
            Console.WriteLine("Enter the n amount of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{harmonic}/{i} + ");
                sum += harmonic/i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of the series up to {n} terms is: {sum:F4}");
        }
    }
}