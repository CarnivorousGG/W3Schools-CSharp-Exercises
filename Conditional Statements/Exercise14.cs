using System;

namespace Conditional_Statements
{
//Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
    public class Exercise14
    {
        public void Start()
        {
            try
            {
                int a, b, c;
                Console.WriteLine("This program will determine whether a triangle is Equilateral, Isosceles or Scalene.");
                Console.WriteLine("Enter side a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter side b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter side c: ");
                c = Convert.ToInt32(Console.ReadLine());

                if (a.Equals(b) && a.Equals(c))
                {
                    Console.WriteLine("This is an Equilateral triangle");
                }
                else if (a.Equals(c) || a.Equals(b) || b.Equals(c))
                {
                    Console.WriteLine("This is an Isosceles triangle");
                }
                else
                {
                    Console.WriteLine("This is a Scalene Triangle");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            
        }
    }
}