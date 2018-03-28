using System;

namespace Conditional_Statements
{
//20. Write a program in C# Sharp to read any day number in integer and display day name in the word.
    public class Exercise20{
        public void Start()
        {
            try
            {
                Console.WriteLine("Enter the day of the week: ");
                var day = Convert.ToInt32(Console.ReadLine());
                if (day == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (day == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (day == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (day == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if (day == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (day == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else if (day == 7)
                {
                    Console.WriteLine("Sunday");
                }
                else
                {
                    Console.WriteLine("Invalid day number!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}