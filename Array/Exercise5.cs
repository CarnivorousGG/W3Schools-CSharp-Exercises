using System;

namespace Array
{
    //Write a program in C# Sharp to count a total number of duplicate elements in an array.
    public class Exercise5
    {
        public void Start()
        {
            int n, count = 1, dup = 0;
            Console.WriteLine("This program will count the total number of duplicate elements in an array");
            Console.WriteLine("Enter the amount of elements you wish the array to consist of : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] arr3 = new int[n];
            
            
            // populate the array
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            // copy the 1st array into a new one so we can compare them
            System.Array.Copy(arr1,arr2, n );
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = count;
                        count++;
                    }
                }
                count = 1;
            }

            // print the array and checking if the elemnt is equal to 2 to increase the count
            for (int i = 0; i < n; i++)
            {
                if (arr3[i] == 2)
                {
                    dup++;
                }
            }
            Console.WriteLine($"The number of duplicate elements: {dup}");
        }
    }
}