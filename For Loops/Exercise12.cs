using System;

namespace For_Loops
{
    public class Exercise12
    {
        // Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
        public void Start()
        {
            int rows, number = 1;
            Console.WriteLine("This program will display a pattern like a right angle triangle with number increased by 1.");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int columns = 1; columns <= i; columns++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}