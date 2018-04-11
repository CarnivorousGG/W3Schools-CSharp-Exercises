using System;

namespace For_Loops
{
    public class Exercise22
    {
        // Write a program in C# Sharp to print the Floyd's Triangle.
        public void Start()
        {
            int n, p, q;
            Console.WriteLine("Print Floyd's Triangle: ");
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine();

            Console.WriteLine("Enter the number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i%2 == 0)
                {
                    p = 1;
                    q = 0;
                }
                else
                {
                    p = 0;
                    q = 1;
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write($"{p}");
                    }
                    else
                    {
                        Console.Write($"{q}");
                    }
                }
                Console.WriteLine();
            }
        }        
    }
}