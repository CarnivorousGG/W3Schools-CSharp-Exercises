using System;
using System.Runtime.InteropServices;

namespace Conditional_Statements
{
//15. Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.   
    public class Exercise15
    {
        public void Start()
        {
            try
            {
                int a, b, c;
                Console.WriteLine("This program will check whether a triangle can be formed by the given value for the angles");
                Console.WriteLine("Enter side a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter side b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter side c: ");
                c = Convert.ToInt32(Console.ReadLine());

                if (a + b + c == 180)
                {
                    Console.WriteLine("The triangle can be formed.");
                }
                else
                {
                    Console.WriteLine("The triangle is invalid!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                
            }
        }
    }
}
