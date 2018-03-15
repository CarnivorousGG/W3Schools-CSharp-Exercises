using System;

namespace W3Schools
{
    public class Exercise5
    {
        public void Start()
        {
            Console.WriteLine("Please, input the radius of the circle: ");
            var radius = int.Parse(Console.ReadLine());
            double PI = 3.14;
            var result = 2 * PI * radius;
            Console.WriteLine("========================================");
            Console.WriteLine($"Perimeter of the Circle: {result}");
        }
    }
}