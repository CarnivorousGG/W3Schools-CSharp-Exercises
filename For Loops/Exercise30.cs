using System;

namespace For_Loops
{
    public class Exercise30
    {
        // Write a C# Sharp program to find the Armstrong number for a given range of number.
        public void Start()
        {
            int start, sum, remainder, end, temp;
            Console.WriteLine("This program will find the Armstrong number/s for a given range.");
            Console.WriteLine("Enter the starting number or range: ");
            start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending number or range: ");
            end = Int32.Parse(Console.ReadLine());

            for (int i = start; i < end; i++)
            {
                temp = i;
                sum = 0;

                while (temp != 0)
                {
                    remainder = temp % 10;
                    temp = temp / 10;
                    sum = sum + (remainder * remainder * remainder);
                }
                if (sum.Equals(i))
                {
                    Console.Write($"{i}" + " ");
                }

            }
            Console.WriteLine();
        }
    }
}