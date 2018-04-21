using System;
using System.Linq;

namespace Array
{
    public class Exercise3
    {
        // Write a program in C# Sharp to find the sum of all elements of the array.
        public void Start()
        {
            int n;
            Console.WriteLine("This program will find the sum of all of the elements entered into the array.");
            Console.WriteLine("Please, enter the number of elements you wish to insert into the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"The sum of the array is {arr.Sum()}");
        }
    }
}