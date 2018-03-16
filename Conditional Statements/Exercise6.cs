using System;

namespace Conditional_Statements
{
    public class Exercise6
    {
        public void Start()
        {
            int m, n;
            Console.WriteLine("--------===--------");
            Console.WriteLine("Please, enter an integer: ");
            Console.WriteLine("--------===--------");

            m = Convert.ToInt32(Console.ReadLine());

            if (m > 0)
            {
                n = 1;
                Console.WriteLine($"n={n}");
            }
            else if (m == 0)
            {
                n = 0;
                Console.WriteLine($"n={n}");
            }
            else
            {
                n = -1;
                Console.WriteLine($"n={n}");
            }

        }              
    }
}