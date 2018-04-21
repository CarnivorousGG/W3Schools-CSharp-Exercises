using System;

namespace For_Loops
{
    //  Write a program in C# Sharp to display the n terms of square natural number and their sum.
    public class Exercise25
    {
        public void Start()

        {
            int sum = 0, terms;
            Console.WriteLine("Enter the number of terms to display the square natural numbers and their sum: ");
            terms = int.Parse(Console.ReadLine());
            Console.Write($"The square natural numbers up to {terms} are: ");
            for (int i = 1; i <= terms; i++)
            {
                Console.Write(i * i + " ");
                sum += i * i;
            }
            Console.WriteLine($"The sum of the numbers is {sum}");
        }
    }
}