using System;
using System.Runtime.InteropServices;

namespace W3Schools
{
    public class Exercise1
    {
       public void Start()
        {
            Console.WriteLine("Please, enter a letter: ");
            var letter1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please, enter a letter: ");
            var letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please, enter a letter: ");
            var letter3 = Convert.ToChar(Console.ReadLine());

            Console.Write("The letters are now reversed: ");
            Console.WriteLine($"{letter3}, {letter2}, {letter1}");

        }
       
    }
}