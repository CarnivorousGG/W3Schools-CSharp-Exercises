using System;

namespace Conditional_Statements
{
    public class Exercise8
    {
        public void Start()
        {
            Console.WriteLine("You need to input 3 numbers, the program will calculate the greatest among the 3");
            Lines();
            Console.WriteLine("Please, enter the first number: ");
            var num1 = int.Parse(Console.ReadLine());
            Lines();
            Console.WriteLine("Please, enter the second number: ");
            var num2 = int.Parse(Console.ReadLine());
            Lines();
            Console.WriteLine("Please, enter the third number: ");
            var num3 = int.Parse(Console.ReadLine());

            Console.Clear();

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("The first number is the greatest among the three!");
            else if (num2 > num3 && num2 > num1)
                Console.WriteLine("The second number is the greatest among the three!");
            else if (num3 > num1 && num3 > num2)
                Console.WriteLine("The third number is the greatest among the three!");
        }

        private void Lines()
        {
            Console.WriteLine("--------------------");
        }
    }
}