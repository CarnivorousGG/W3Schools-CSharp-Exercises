using System;

namespace Conditional_Statements
{
    public class Exercise16
    {
        //Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
        public void Start()
        {
            Console.WriteLine("This program will determine if the letter is a vowel or a consonant.");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Enter a letter: ");
            var letter = (Console.ReadLine());

            Console.Clear();


            Console.WriteLine("aoeiu".Contains(letter) ? "The letter is a vowel!" : "The letter is a consonant!");
            Console.WriteLine("--------------------------------------------------------------------");
        }        
    }
}