using System;

namespace Conditional_Statements
{
    public class Exercise1
    {
        public void Start()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("This program will determine if the number you enter are equal or not");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Please, enter a number: ");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            var n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                Console.WriteLine("The numbers are not equal!");
            }
        }
    }
}