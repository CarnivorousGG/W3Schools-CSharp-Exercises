using System;
using System.Threading;

namespace For_Loops
{
    public class Exercise16
    {
        //  Write a program in C# Sharp to display the n terms of even natural number and their sum.
        public void Start()
        {
            
            try
            {
                int n, sum = 0;
                Console.WriteLine("This program will display the n temrs of even natural numbers and their sum.");
                Console.WriteLine("Please, enter the number of terms: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Thread.Sleep(750);
                Console.WriteLine("The even natural numbers are: ");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i * 2 + " ");
                    sum += i * 2;
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