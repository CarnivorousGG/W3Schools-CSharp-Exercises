using System;

namespace Conditional_Statements
{
    // 21. Write a program in C# Sharp to read any digit, display in the word.
    public class Exercise21
    {
        public void Start()
        {
            try
            {
                Console.WriteLine("Input a digit and it will be displayed as a word: ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))

                {
                    Console.WriteLine("Invalid input!");
                return;       
                }
                var digit = Convert.ToInt32(input);

                switch (digit)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                        default:
                            Console.WriteLine("Invalid digit!");
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