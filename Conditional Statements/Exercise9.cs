using System;

namespace Conditional_Statements
{
// Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
    public class Exercise9
    {
        public void Start()
        {
            try
            {
                Console.WriteLine(
                    "This program will determine in which quadrant of the XY coordinate system", /*Environment.NewLine,*/
                    "the point you enter will lie");
                Console.WriteLine("Input the value for the X coordinate: ");
                var x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the value for the Y coordinate: ");
                var y = Convert.ToInt32(Console.ReadLine());
                if (x == 0 && y == 0)
                    Console.WriteLine("The point is at 0");

                if (x >= 0 && y > 0)
                    Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
                else if (x >= 0 && y < 0)
                    Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
                else if (x <= 0 && y < 0)
                    Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
                else
                    Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}