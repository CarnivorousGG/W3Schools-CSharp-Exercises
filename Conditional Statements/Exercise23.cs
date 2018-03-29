using System;

namespace Conditional_Statements
{
    public class Exercise23
    {
        public void Start()
        {


            try
            {
                int month;
                Console.WriteLine();
                Console.WriteLine("Read a month's number and the program will display the number of days in it: ");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine();

                month = Convert.ToInt32(Console.ReadLine());

                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("The month has 31 days.");
                        break;
                    case 2:
                        Console.WriteLine("The 2nd month is February and it has 28 days.");
                        Console.Write("in leap year February has 29 days.\n");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("The month has 30 days.");
                        break;
                    default:
                        Console.WriteLine("Invalid month number!");
                        break;

                }
            }
            catch
                (Exception e)
            {
                Console.WriteLine(e);

            }


        }
    }
}