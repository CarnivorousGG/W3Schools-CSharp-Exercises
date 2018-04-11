using System;
using System.Net.Sockets;

namespace For_Loops
{
    public class Exercise13
    {
        // Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1.
        public void Start()
        {
            int num = 1, rows, spaces;
            Console.WriteLine("This program will display a pattern like a pyramid with numbers increased by 1");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Enter the number of rows for the pyramid: ");
            rows = Convert.ToInt32(Console.ReadLine());
            spaces = rows;

            for (int i = 1; i <= rows; i++) //creates the number of rows
            {
                for (int j = spaces; j >= 1; j--) // creates the amount of white spaces needed
                {
                    Console.Write(" ");
                    
                }
                for (int j = 1; j < i; j++) // prints the number in an increasing order
                {

                    Console.Write(num++ + " ");
                    
                }
                Console.WriteLine();
                spaces--; // each cycle we reduce the number of spaces we need to print
            }

        }
    }
}