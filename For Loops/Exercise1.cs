using System;
using System.Threading;

namespace For_Loops
{
//1. Write a program in C# Sharp to display the first 10 natural numbers.
    public class Exercise1
    {
        public void Start()
        {
            Console.WriteLine("This program will display the first 10 natural numbers: ");
            Thread.Sleep(1700);

            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}