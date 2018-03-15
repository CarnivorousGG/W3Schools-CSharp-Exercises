using System;

namespace W3Schools
{
    public class Exercise10
    {
        public void Start()
        {
            Console.WriteLine("If the 2 numbers are both odd or even you will see the result, otherwise it will be false");
            Console.WriteLine("Please, enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 2 == 0 && n2 % 2 ==0)
            {
                Console.WriteLine("The numbers are even");
            }
            else if (n1 % 2 != 0 && n2 % 2 !=0)
            {
                Console.WriteLine("The numbers are odd");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}