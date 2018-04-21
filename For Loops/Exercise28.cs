using System;

namespace For_Loops
{
    public class Exercise28
    {
        //  Write a C# Sharp program to find the perfect numbers within a given range of number. 
        public void Start()
        {
            int start, end, sum, i;
            Console.WriteLine("This program will find the perfect numbers within a given range.");
            Console.WriteLine("Please, input the starting range or number: ");
            start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, input the ending range or number: ");
            end = Int32.Parse(Console.ReadLine());

            Console.Write("The perfect numbers within the given range are: ");
            for (int n = start; n <= end; n++)
            {
                sum = 0;
                i = 1;
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;
                    }
                    i++;
                }
                if (sum.Equals(n))
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
    }
}