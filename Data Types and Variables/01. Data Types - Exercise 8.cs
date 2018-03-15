using System;

namespace W3Schools
{
    public class Exercise8
    {
        public void Start()
        {
            Console.WriteLine("We are about to calculate the surface and volume of a sphere.");
            Console.WriteLine("Please, enter a radius: ");
            var radius = int.Parse(Console.ReadLine());
            float pi = 3.1415926535f; //define pi without using the built in math library
            
            var sphere = (4 * pi* (radius * radius)); //formula to calculate the sphere 
            var surface = (4f / 3f * pi * (radius * radius * radius)); // formula to calculate the surface

            Console.WriteLine($"Volume of the sphere: {sphere}");
            Console.WriteLine($"The surface: {surface}");

        }
    }
}