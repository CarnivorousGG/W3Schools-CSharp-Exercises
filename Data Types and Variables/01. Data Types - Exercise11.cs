using System;

namespace W3Schools
{
    public class Exercise11
    {
        public void Start()
        {
            Console.WriteLine("Please enter a number to be converted to binary or type 'end' to stop the program");
            while (true)
            {
                var input = Console.ReadLine();
               

                if (input == "end")
                {
                    Console.WriteLine("Stopped the program.");
                    break;
                }
                var inputParsed = int.Parse(input);

                var binary = Convert.ToString(inputParsed, 2);
                Console.WriteLine(binary);
            }
        }
    }
}