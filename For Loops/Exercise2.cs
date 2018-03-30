using System;
using System.Threading;

namespace For_Loops
{
//2. Write a C# Sharp program to find the sum of first 10 natural numbers.
    public class Exercise2
    {
        public void Start()
        {
            try
            {
                int sum = 0;
                Console.WriteLine("This program will display the first 10 natural numbers and their sum.");
                Thread.Sleep(1000);
                Console.WriteLine("The first 10 natural numbers are: ");
                Thread.Sleep(1000);

                for (int i = 1; i < 11; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.WriteLine();

                Console.WriteLine($"The sum is {sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
            
        }
    }
}