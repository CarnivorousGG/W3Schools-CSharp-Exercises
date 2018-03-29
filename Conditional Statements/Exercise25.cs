using System;


namespace Conditional_Statements
{
//25. Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
    public class Exercise25
    {
        public void Start()
        {
            try
            {
                int num1, num2, choice;
                Console.WriteLine();
                Console.WriteLine("This is a menu driven program, you will enter two integers and your choice of calculation.");
                Console.WriteLine();
                Console.WriteLine("Enter the first integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Here are the options: ");
                Console.WriteLine("1-Addition.", Environment.NewLine,
                    "2-Substraction", Environment.NewLine,
                    "3-Multiplication", Environment.NewLine, 
                    "4-Division", Environment.NewLine,
                    "5-Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"The addition of {num1} and {num2} is {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"The substraction of {num1} and {num2} is {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"The multiplication of {num1} and {num2} is {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"The division of {num1} and {num2} is {num1 / num2}");
                        break;
                    case 5:
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