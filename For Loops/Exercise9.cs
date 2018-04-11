using System;
using System.Runtime.InteropServices;

namespace For_Loops
{
    public class Exercise9
    {
        // 9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk
        public void Start()
        {
            int rows;
            Console.WriteLine("This program will display a pattern like a right angle triangle using an asterisk.");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());


            for ( int i = 1; i <= rows; i++)
            {
                for (int columns = 1; columns <= i; columns++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
        }
    }
}