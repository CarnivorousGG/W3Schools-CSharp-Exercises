using System;
using System.Threading;

namespace For_Loops
{
    public class Exercise6
    {
        // Write a program in C# Sharp to display the multiplication table of a given integer.
        public void Start()
        {
            try
            {
                int n;
                Console.WriteLine("This program will display the multiplication table of a given integer.");
                Thread.Sleep(750);
                Console.WriteLine("Enter the integer: ");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}