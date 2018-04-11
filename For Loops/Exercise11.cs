using System;

namespace For_Loops
{
    public class Exercise11
    {
        public void Start()
        {
            int rows;
            Console.WriteLine("This program will display a pattern like a right angle triangle using an asterisk.");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows; i++)
            {
                for (int columns = 1; columns <= i; columns++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }
        }
    }
}