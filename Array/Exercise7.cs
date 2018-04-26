using System;
using System.Threading;

namespace Array
{
    public class Exercise7
    {
        // Write a program in C# Sharp to merge two arrays of same size sorted in ascending order. 
        public void Start()
        {
            int a1, a2, l, temp, i = 0;

            Console.WriteLine("This program will merge two arrays of into one, then sorted in ascending order.");
            Console.WriteLine("Enter the number of elements for the first array: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[a1];
            Console.WriteLine("Enter the number of elements for the second array: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[a2];
            Console.WriteLine();
            Console.WriteLine("Now you will need to enter the elements in both arrays.");
            Thread.Sleep(600);

            Console.WriteLine("Enter the elements of the first array.");
            
            // populating the first array 

            for ( i = 0; i < a1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("Enter the elements of the second array.");

            // populating the second array

            for (i = 0; i < a2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            l = a1 + a2; // lenght of both arrays into the 3rd one
            int[] arr3 = new int[l];

            // ---- Inserting the elements into the third array

            for (i = 0; i < a1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int j = 0; j < a2; j++)
            {
               
                arr3[i] = arr2[j];
                i++;
            }

            // Sorting the 3rd array

            for ( i = 0 ; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (arr3[j] >= arr3[j+1])
                    {
                        temp = arr3[j + 1];
                        arr3[j + 1] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }

            // print the array

            Console.WriteLine("The elements sorted in the third array are: ");
            Console.WriteLine(string.Join(" ", arr3));
           

        }
    }
}
