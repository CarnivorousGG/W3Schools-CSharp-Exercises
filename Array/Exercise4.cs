using System;

namespace Array
{
    public class Exercise4
    {
        // Write a program in C# Sharp to copy the elements one array into another array.
        public void Start()
        {
            int n;

            Console.WriteLine("This program will copy the elements of one are into another");
            Console.WriteLine("Please, enter the number of elements you wish to pass into the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }

            // copy the elements of the first array to the second one

            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
            // can be replaced by Array.Copy(arr1, arr2);

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        } 
    }
}