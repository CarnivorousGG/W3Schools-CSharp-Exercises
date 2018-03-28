using System;
using System.Threading;

namespace Conditional_Statements
{
    public class Exercise18
    {
        public double percent;

        //Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
        //    The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer.
        public void Start()
        {
            try
            {
                int units;
                double charge;

                Console.WriteLine("This program will calculate your electricity bill. The charges are as follow: ");
                Seperator();
                Console.WriteLine("Up to 199 units you will be charged @1.20 per unit");
                Console.WriteLine("200 and above but less than 400 you will be charged @1.50 per unit");
                Console.WriteLine("400 and above but less than 600 you will be charged @1.80 per unit");
                Console.WriteLine("Above 600 you will be charged @2.00 per unit");
                Seperator();

                Console.WriteLine("ATTENTION!");
                Console.WriteLine("If you go above 400 units, a surchage of 15% will be charged!");
                Seperator();
                Console.WriteLine("Enter your ID number: ");
                var id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your name: ");
                var name = Console.ReadLine().Trim();

                Console.WriteLine("Enter the amount of electricity you have consumed: ");
                units = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine($"Customer IDNO: {id}");
                Console.WriteLine($"Custonamer name: {name}");

                if (units < 100)
                {
                    Console.WriteLine("You need to have consumed atleast 100 units!");
                    return;
                }

                Console.WriteLine($"The amount of electricty consumed is {units}");

                if (units <= 199)
                {
                    charge = 1.20;
                    Console.WriteLine($"Amount charges @1.20 per unit: {units * charge}");
                    Console.WriteLine($"Your total bill is: {units * charge}");
                }
                else if (units >= 200 && units < 400)
                {
                    charge = 1.50;
                    Console.WriteLine($"Amount charges @1.50 per unit: {units * charge}");
                    Console.WriteLine($"Your total bill is: {units * charge}");
                }
                else if (units >= 400 && units < 600)
                {
                    charge = 1.80;
                    var total = units * charge;
                    if (total >= 400)
                    {
                        percent = total * 0.15;
                        total += percent;
                    }

                    Console.WriteLine($"Amount charges @1.80 per unit: {units * charge}");
                    Console.WriteLine($"Surcharge amount: {percent}");
                    Console.WriteLine($"Your total bill is: {total}");
                }
                else
                {
                    charge = 2.00;
                    var total = units * charge;
                    if (total >= 400)
                    {
                        percent = total * 0.15;
                        total += percent;
                    }

                    Console.WriteLine($"Amount charges @2.0 per unit: {units * charge}");
                    Console.WriteLine($"Surcharge amount: {percent}");
                    Console.WriteLine($"Your total bill is: {total}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The input was not in the correct format, you need to enter a whole number!");
            }
        }

        private void Seperator()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("=========================");
            Console.WriteLine("-------------------------");
        }
    }
}