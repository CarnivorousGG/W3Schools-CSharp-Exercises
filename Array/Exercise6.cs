using System;
using System.Collections.Generic;
using System.Linq;

namespace Array
{
    //  Write a program in C# Sharp to print all unique elements in an array. 
    public class Exercise6
    {
        public void Start()
        {
            int n, count = 0;
            Console.WriteLine("This program will print all of the unique elements in an array.");
            Console.WriteLine("Enter the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
       

            List<int> arr = new List<int>();
            List<int> arr2 = new List<int>();

            for (int j = 0; j < n; j++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                arr.Add(input);
            }

            for (int i = 0; i < n; i++)
            {

                count = 0;
                for (int j = 0; j < n; j++)
                {
                   
                    if (arr[i] == arr[j])
                    {
                        count++;

                    }

                }
                if (count == 1)
                {
                    arr2.Add(arr[i]);
                }
               

            }
            

          

             //var distinct = arr.Distinct().ToList();

            
            
            

            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}