using System;
using System.Threading;

namespace W3Schools
{
    public class Exercise2
    {
        
        
        public void Start()
        {
            Console.WriteLine("Please, enter a number: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the desired width: ");
            int width = int.Parse(Console.ReadLine());

            int height = width;
            for (int rows = 0; rows < height; rows++) //this will print the desires number of rows
            {
                for (int column = 0; column < width; column++) //this will prinnt the number each time
                {
                    Console.Write(number + " ");
                    //print the number 
                }
                Console.WriteLine();//make a new line to seperate the numbers
                width--; // reduce the width each time so we print 1 less number
            }
            
        }
    }
}