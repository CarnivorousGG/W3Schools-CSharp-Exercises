using System;

namespace Conditional_Statements
{
    public class Exercise10
    {
        public void Start()
        {
            try
            {
                Console.WriteLine(
                    "Please, enter your marks in the subjects and the program will tell you if you are eligible for admission");
                Seperator();
                Console.WriteLine("Input the marks obtained in Physics: ");
                var p = Convert.ToInt32(Console.ReadLine());
                Seperator();
                Console.WriteLine("Input the marks obtained in Chemistry: ");
                var c = Convert.ToInt32(Console.ReadLine());
                Seperator();
                Console.WriteLine("Input the marks obtained in Mathematics: ");
                var m = Convert.ToInt32(Console.ReadLine());
                Seperator();

                if (m >= 65 && p >= 55 && c >= 50)
                    if (m + c + p >= 180 || m + p >= 140)

                        Console.WriteLine("You are eligible for admission!");
                    else
                        Console.WriteLine("You are not eligible for admission, sorry.");
                else
                    Console.WriteLine("You are not eligible for admission, sorry.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Seperator()
        {
            Console.WriteLine("----------=====----------");
        }
    }
}