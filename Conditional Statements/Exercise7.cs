using System;

namespace Conditional_Statements
{
    public class Exercise7
    {
        public void Start()
        {
            Console.WriteLine("_______-------=====-------_______");
            Console.WriteLine("This program will determine the height of a person");
            Console.WriteLine("_______-------=====-------_______");
            Console.WriteLine("Please, enter your height: ");
            Console.WriteLine("=================================");

            var height = Convert.ToInt32(Console.ReadLine());

            if (height < 140)
            {
                Console.WriteLine("The person is a Dwarf. Kappa Kappa");
            }
            else if (height > 140 && height < 160)
            {
                Console.WriteLine("The person is short");
            }
            else if (height > 160 && height <= 189)
            {
                Console.WriteLine("The person is tall");
            }
            else if (height >= 190)
            {
                Console.WriteLine("The person is very tall, almost a giant. Kappa");
            }
        }
    }
}