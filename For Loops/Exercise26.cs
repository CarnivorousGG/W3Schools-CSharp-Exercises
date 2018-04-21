using System;

namespace For_Loops
{
    // . Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
    public class Exercise26
    {
        public void Start()
        {
            int terms, sum = 0, t = 1;
            Console.WriteLine("Enter the amount of terms you want the series of 1 + 11 + 111 + the amount of terms: ");
            terms = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < terms; i++)
            {
                Console.Write($"{t} +");
                sum = sum + t;
                t = (t * 10) + 1;
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of the numbers is {sum}");
        }
    }
}