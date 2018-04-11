using System;

namespace For_Loops
{
    public class Exercise20
    {
        //  Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks.
        public void Start()
        {
            try
            {
                int rows, spaces;
                Console.WriteLine("This program will display a pattern like a pyramid using an asterisk, each row will contain an odd number of asterisks.");
                Console.WriteLine("Input the number of rows: ");
                rows = Convert.ToInt32(Console.ReadLine());

                spaces = rows;
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = spaces; j>= 1 ; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <=2*i-1; j++) // 
                    {
                        Console.Write("*");
                    }
                    spaces--;
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
        }
    }
}