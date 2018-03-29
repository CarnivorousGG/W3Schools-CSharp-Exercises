using System;

namespace Conditional_Statements
{
    public class Exercise22
    {
    //22. Write a program in C# Sharp to read any Month Number in integer and display Month name in the word.
        public void Start()
        {
            try
            {
                Console.WriteLine("Enter the number of a month and it will be displayed as a word: ");
                var num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                    default:
                        Console.WriteLine("Wrong number! You need to enter a month as a number");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}