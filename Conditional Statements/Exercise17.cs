using System;

namespace Conditional_Statements
{
    public class Exercise17
    {
        public void Start()
        {
            int production, transaction;
            Console.WriteLine("This program will calculate loss or profit on a transaction.");
            Console.WriteLine("Enter your production cost: ");
            production = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the transaction value: ");
            transaction = Convert.ToInt32(Console.ReadLine());

            if (production < transaction)
            {
                var profit = transaction - production;
                Console.WriteLine($"You made a profit of {profit}");
            }
            else
            {
                var loss = production - transaction;
                Console.WriteLine($"You lost {loss} in the transaction");
            }
        }
}
}