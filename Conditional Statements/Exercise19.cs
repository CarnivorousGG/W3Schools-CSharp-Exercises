using System;
using System.Runtime.InteropServices;

namespace Conditional_Statements
{
//19. Write a program in C# Sharp to accept a grade and declare the equivalent description
    public class Exercise19
    {
        public void Start()
        {
            Console.WriteLine("Please enter your grade: ");
            var input = Console.ReadLine().ToLower().Trim();
            var grade = char.Parse(input);

            switch (grade)
            {
                case 'e':
                    Console.WriteLine("Excellent!");
                    break;
                case 'v':
                    Console.WriteLine("Very Good!");
                    break;
                case 'g':
                    Console.WriteLine("Good!");
                    break;
                case 'a':
                    Console.WriteLine("Avarage!");
                    break;
                case 'f':
                    Console.WriteLine("Fail!");
                    break;
                    default:
                        Console.WriteLine("Wrong character entered!");
                        break;

            }
        }
    }
}