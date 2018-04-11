using System;

namespace For_Loops
{
    public class Exercise14
    {
        // Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
        public void Start()
        {
            int rows, spaces;
            Console.WriteLine("This program will display a pattern like a pyramid with an asterisk");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Enter the number of rows for the pyramid: ");
            rows = Convert.ToInt32(Console.ReadLine());
            if (rows > 30)
            {
                rows = 30;
            }
            spaces = rows;

            

            for (int i = 1; i <= rows; i++)
            {
                for (int j = spaces; j>= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
                spaces--;
            }
        }
    }
}