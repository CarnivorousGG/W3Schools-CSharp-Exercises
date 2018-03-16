using System;

namespace Conditional_Statements
{
    public class Exercise2
    {
        public void Start()
        {
            Console.WriteLine("The program will determine if the integer you input is odd or even");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Please, enter an integer: ");

            var num = int.Parse(Console.ReadLine());

            Console.Clear();

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even integer");
            }
            else
            {
                Console.WriteLine($"{num} is an odd integer");
            }
        }
    }
}