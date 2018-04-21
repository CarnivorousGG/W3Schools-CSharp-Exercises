using System;

namespace Array
{
    public class Exercise1
    {
        // Write a program in C# Sharp to store elements in an array and print it
        public void Start()
        {
            int n, e = 1;
            Console.WriteLine("This program will store elements in an array.");
            Console.WriteLine("Please, input the number of elements you wish to store: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n ; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Element {e} - {arr[i]}");
                Console.WriteLine();
                
                e++;
            }

            Console.WriteLine(string.Join(" ", arr));
        }

    }
}