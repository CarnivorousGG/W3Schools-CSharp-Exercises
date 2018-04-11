using System;

namespace For_Loops
{
    public class Exercise17
    {
        // 17. Write a program in C# Sharp to make such a pattern like a pyramid witha number which will repeat the number in the same row.
        public void Start()
        {
            
            try
            {
                int rows, spaces;
                Console.WriteLine("This program will make a pattern like a pyramid with a number whill will repeat in the same row.");
                Console.WriteLine("Please, enter the number of rows: ");
                rows = Convert.ToInt32(Console.ReadLine());
                spaces = rows;

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = spaces; j >= 1; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    spaces--;
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }        
    }
}