    using System;

namespace Conditional_Statements
{
//  Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below
    public class Exercise13
    {
        public void Start()
        {
            try
            {
                int temp;
                Console.WriteLine("Please enter the tempreture in celsius");
                var input = (Console.ReadLine());
                if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Wrong input");

                }
                temp = Convert.ToInt32(input);

                if (temp < 0)
                {
                    Console.WriteLine("Freezing weather!");

                }
                else if (temp >= 0 && temp <= 10)
                {
                    Console.WriteLine("Very cold weather!");
                }
                else if (temp >= 10 && temp <= 20)
                {
                    Console.WriteLine("Cold weather!");
                }
                else if (temp >= 20 && temp <= 30)
                {
                    Console.WriteLine("Normal temperature!");
                }
                else if (temp >= 30 && temp <= 40)
                {
                    Console.WriteLine("It's hot!");
                }
                else
                {
                    Console.WriteLine("It's very hot!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

        }
    }
}