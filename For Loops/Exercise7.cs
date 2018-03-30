using System;
using System.Dynamic;

namespace For_Loops
{
    public class Exercise7
    {
        // Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
        
        public void Start()
        {
            int n;
            Console.WriteLine("Input upto the table number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The multiplication from 1 to {n} is: ");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j<=n-1)
                    {
                        Console.Write($"{j} x {i} = {i * j}, ");
                    }
                    else
                    {
                        Console.Write($"{j} x {i} = {i * j}");
                    }
                    
                }
                Console.WriteLine();
            }
                  
        }
    }
}