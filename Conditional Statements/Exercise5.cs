using System;

namespace Conditional_Statements
{
    public class Exercise5
    {
        public void Start()
        {
            Console.WriteLine("This program will determine if you are eligible to vote!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Please, enter your age: ");

            var age = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (age >= 21)
            {
                Console.WriteLine("Congratulations! You are eligible to cast your vote!");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible to vote");
            }
        }
     
    }
}