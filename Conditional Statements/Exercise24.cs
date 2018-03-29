using System;

namespace Conditional_Statements
{
    public class Exercise24
    {
        public void Start()
        {
            {
                int choice, r, l, w, b, h;
                double area = 0;

                
                Console.WriteLine("A menu driven program to compute the area of various geometrical shape: ");
                Console.WriteLine("-------------------------------------------------------------------------");
                


                Console.WriteLine("Input 1 for area of circle");
                Console.WriteLine("Input 2 for area of rectangle");
                Console.WriteLine("Input 3 for area of triangle");
                Console.WriteLine("Input your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input radius of the circle : ");
                        r = Convert.ToInt32(Console.ReadLine());
                        area = 3.14 * r * r;
                        break;
                    case 2:
                        Console.WriteLine("Input length  of the rectangle : ");
                        l = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input  width of the rectangle : ");
                        w = Convert.ToInt32(Console.ReadLine());
                        area = l * w;
                        break;
                    case 3:
                        Console.WriteLine("Input the base of the triangle :");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input the hight of the triangle :");
                        h = Convert.ToInt32(Console.ReadLine());
                        area = .5 * b * h;
                        break;
                }
                Console.WriteLine("The area is: ");
                Console.WriteLine(area);
            }
        }
    }
    }
