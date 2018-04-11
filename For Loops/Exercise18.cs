using System;

namespace For_Loops
{
    public class Exercise18
    {
        // Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........]
        public void Start()
        {
          
            double sum, t, terms, x, d;
            Console.WriteLine("This program will calculate the sum of the series [1-X^2/2!+X^4/4!- .........]");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Enter the value of x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of terms: ");
            terms = Convert.ToInt32(Console.ReadLine());

            sum = 1;
            t = 1;

            for (int i = 1; i <= terms; i++)
            {
                d = (2 * i) * (2 * i - 1);
                t = -t * x * x / d;
                sum = sum + t;
            }

            Console.WriteLine($"The sum = {sum}", Environment.NewLine,
                $"Number of terms: {terms} ", Environment.NewLine,
                $"Value of x: {x}");
        }
    }
}