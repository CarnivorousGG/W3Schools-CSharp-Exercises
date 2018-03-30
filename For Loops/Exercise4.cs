using System;
using System.Threading;

namespace For_Loops
{
    public class Exercise4
    {
        //4. Write a program in C# Sharp to display n terms of natural number and their sum.
        public void Start()
        {
            try
            {
                int sum = 0;
                Console.WriteLine("You will enter 10 numbers.");
                Thread.Sleep(1200);

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Enter number {i}");
                    var number = int.Parse(Console.ReadLine());
                    sum += number;
                }
                Thread.Sleep(600);

                Console.WriteLine($"The sum of 10 numbers is: {sum}");
                Console.WriteLine($"The avarage is: {sum / 10}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

}
