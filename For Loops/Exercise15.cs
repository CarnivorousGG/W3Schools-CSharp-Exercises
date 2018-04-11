using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace For_Loops
{
    // 15. Write a C# Sharp program to calculate the factorial of a given number.
    public class Exercise15
    {
        public void Start()
        {
            try
            {
                int num, fractorial;
                Console.WriteLine("This program will calculate the factorial of a given number.");
                Console.WriteLine("Enter the number: ");
                num = Convert.ToInt32(Console.ReadLine());
                fractorial = num;

                for (int i = 1; i < num; i++)
                {
                    fractorial = fractorial * i ;
                }

                Console.WriteLine($"The fractorial of {num} is {fractorial}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                
            }
           
        }
    }
} 