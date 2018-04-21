using System;

namespace Array
{
    public class Exercise2
    {
        // Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
        public void Start()
        {
            int n, e = 1;
            Console.WriteLine("This program will rean n number amount of values, store them in an array and display them in a reversed order.");
            Console.WriteLine("Enter the number of elements to store in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Element {e} - {arr[i]}");
                e++;
                Console.WriteLine();
            }

            System.Array.Reverse(arr);
            Console.Write("The values stored in the reverse array are: ");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}