using System;
using System.ComponentModel.Design;

namespace W3Schools
{
    public class Exercise9
    {
        public void Start()
        {
            Console.WriteLine("This program will determine the type of character you have entered.");
            Console.WriteLine("Please enter a character:");

            var a = char.Parse(Console.ReadLine());

            bool isVowel = "aeiouAEIOU".IndexOf(a) >= 0;

            if (char.IsDigit(a))
            {
                Console.WriteLine("The character is a digit!");
            }
            else if (isVowel)
            {
                Console.WriteLine("The character is a vowel!");
            }
            else
            {
                Console.WriteLine("The character is a consonant!");
            }
            
        }
    }
}