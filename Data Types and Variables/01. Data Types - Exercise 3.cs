using System;

namespace W3Schools
{
// Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
    public class Exercise3
    {
        public void Start()
        {
            var atempts = 0;

            var username = "username";
            var password = "password";

            Console.WriteLine($"The default login is Username: {username} and the password is: {password}");
            Console.WriteLine("Please, enter a username: ");

            while (atempts < 3)
            {
                var usernameInput = Console.ReadLine();
                if (usernameInput != username)
                {
                    atempts++;
                    Console.WriteLine("Wrong username, please try again!");
                }
                else
                {
                    Console.WriteLine("Correct username!");
                    Console.WriteLine("Please, enter your password: ");
                    while (atempts < 3)
                    {
                        var passwordInput = Console.ReadLine();
                        if (passwordInput == password)
                        {
                            Console.WriteLine("Correct password. You have successfully logged in! Kappa");
                            return;
                        }
                        Console.WriteLine("Wrong password, please try again. Kappa");
                        atempts++;
                    }
                }
            }
        }
    }
}