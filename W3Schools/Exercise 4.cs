using System;

namespace W3Schools
{
    internal partial class ExerciseTester
    {
        public class Exercise4
        {
            public void Start()
            {
                Console.WriteLine("This is a simple calculator, you will have to enter two numbers and the desired operation between them to calculate te result.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Input the first number:");
                var firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Input the desired operation:");
                string operation = Console.ReadLine();
                Console.WriteLine("Input the second number:");
                var secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine("=======================");

                switch (operation)
                {
                    case "+":
                        var add = firstNum + secondNum;
                        Console.WriteLine($"{firstNum} {operation} {secondNum} = {firstNum + secondNum}");
                        break;
                    case "-":
                        Console.WriteLine($"{firstNum} {operation} {secondNum} = {firstNum - secondNum}");
                        break;
                    case "*":
                    Console.WriteLine($"{firstNum} {operation} {secondNum} = {firstNum * secondNum}");
                        break;

                    case "x":
                        Console.WriteLine($"{firstNum} {operation} {secondNum} = {firstNum * secondNum}");
                        break;

                    case "/":
                        Console.WriteLine($"{firstNum} {operation} {secondNum} = {firstNum / secondNum}");
                        break;

                        default: Console.WriteLine("Wrong operator!");
                            break;




                }

            }
        }
    }
}