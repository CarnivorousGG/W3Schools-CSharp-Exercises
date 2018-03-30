using System;

namespace For_Loops
{
    public class Exercise5
    {
        // 5. Write a program in C# Sharp to display the cube of the number upto given an integer.
        public void Start()
        {
            int n;
            Console.WriteLine("Please, input the number of terms for calculation: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"The number is: {i} and the cube of {i} is: {i * i * i} ");
            }
        }
    
    }
}