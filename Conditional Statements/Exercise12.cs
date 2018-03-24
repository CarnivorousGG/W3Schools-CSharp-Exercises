using System;
using System.Linq;

namespace Conditional_Statements
{
    public class Exercise12
    {
        //Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division
        public void Start()
        {
            Console.WriteLine("Input the roll number of the student: ");
            var rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the student: ");
            var name = Console.ReadLine();
            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application seperated by a space: ");
            var marks = Console.ReadLine()
                .Trim()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string division;

            var totalMarks = marks.Sum();
            var percentage = totalMarks / 3.0;

            if (percentage>= 60)
            {
                division = "Frst";
            }
            else if (percentage<60 && percentage>=48)
            {
                division = "Second";
            }
            else if (percentage<48 && percentage>=36)
            {
                division = "Pass";
            }
            else
            {
                division = "Fail";
            }

            Console.WriteLine($"Roll number: {rollno}");
            Console.WriteLine($"Name of student: {name}");
            Console.WriteLine($"Marks in Physics: {marks[0]}");
            Console.WriteLine($"Marks in Chemistry: {marks[1]}");
            Console.WriteLine($"Marks in Computer Application: {marks[2]}");
            Console.WriteLine($"Percentage: {percentage:F2}");
            Console.WriteLine($"Division = {division}");
        }   
    }
}