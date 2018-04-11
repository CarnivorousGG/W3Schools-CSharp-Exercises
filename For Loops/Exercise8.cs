using System;

namespace For_Loops
{
    // 8. Write a program in C# Sharp to display the n terms of odd natural number and their sum.
    public class Exercise8
    {
        public void Start()
        {
            try
            {
                int n, sum = 0;
                Console.WriteLine();
                Console.WriteLine("Display the sum of n odd natural numbers: ");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write((2 * i - 1) + " ");
                    sum += 2 * i - 1;
                }
                Console.WriteLine();
                Console.WriteLine($"The sum of natural odd numbres up to {n} is {sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}