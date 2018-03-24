using System;

namespace Conditional_Statements
{
//Write a C# Sharp program to calculate root of Quadratic Equation.
    public class Exercise11
    {
        public void Start()
        {
            int a, b, c;
            double equation, x1, x2;


            Console.WriteLine("Calculate the root of a Quadratic Equation: ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Input the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of c: ");
            c = Convert.ToInt32(Console.ReadLine());

            equation = b * b - 4 * a * c;
            if (equation==0)
            {
                Console.WriteLine("Both roots are equal.");
                x1 = -b / (2.0 * a);
                x2 = x1;

                Console.WriteLine($"First Root = {x1}");
                Console.WriteLine($"Second root = {x2}");

            }
            else if (equation > 0)
            {
                x1 = (-b + Math.Sqrt(equation)) / (2 * a);
                x2 = (-b - Math.Sqrt(equation)) / (2 * a);
                Console.WriteLine($"First Root = {x1}");
                Console.WriteLine($"Second root = {x2}");
            }
            else
            {
                Console.WriteLine("The roots are imaginary");
            }


        }
    }
}