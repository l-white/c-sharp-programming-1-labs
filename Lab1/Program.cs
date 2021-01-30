using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic User Interaction
            string name = string.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello " + name);
            // Parsing Data - Birthday
            string dobInput = string.Empty;
            Console.Write("Please enter your date of birth: ");
            dobInput = Console.ReadLine();
            DateTime dob = DateTime.MinValue;
            if (DateTime.TryParse(dobInput, out dob))
            {
                Console.WriteLine("Your birthday is " + dob.ToShortDateString() + " which was a " + dob.DayOfWeek + ".");
            }
            else 
            {
                Console.WriteLine("That is an invalid birthday!");
            }
            // Parsing Data - ID
            string idInput = string.Empty;
            Console.Write("Please enter your ID number: ");
            idInput = Console.ReadLine();
            int id = int.MinValue;
            if (int.TryParse(idInput, out id) == true)
            {
                Console.WriteLine("Your ID number is " + id);
            }
            else
            {
                Console.WriteLine("Bad input value!");
            }
            // Parsing Data - Salary
            string salaryInput = string.Empty;
            Console.Write("Please enter your salary: ");
            salaryInput = Console.ReadLine();
            double salary = double.MinValue;
            if (double.TryParse(salaryInput, out salary) == true)
            {
                Console.WriteLine("Your salary is $" + salary);
            }
            else 
            {
                Console.WriteLine("Bad input value!");
            }
            // Parsing Data - Employment
            string employmentInput = string.Empty;
            Console.Write("Are you employed? Enter true or false: ");
            employmentInput = Console.ReadLine();
            Boolean parsedValue;
            if (Boolean.TryParse(employmentInput, out parsedValue))
            {
                if (parsedValue == true)
                {
                    Console.WriteLine("You are currently employed.");
                }
                else
                {
                    Console.WriteLine("You are currently not employed.");
                }
            }
            else
            {
                Console.WriteLine("Bad input value!");
            }
            Console.WriteLine("---------------------");
            // Mathematical Operations - Problem 1
            double width = 6.5;
            int height = 3;
            double area = width * height;
            Console.WriteLine("<ANSWER 1> " + area);
            // Mathematical Operations - Problem 2
            double radius = 7.1;
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine("<ANSWER 2> " + circleArea);
            // Mathematical Operations - Problem 3
            double answer3a = Math.Sqrt(Math.Pow((5 - 2), 2) + Math.Pow(7 - (-3), 2));
            Console.WriteLine("<ANSWER 3a> " + answer3a);
            double answer3b = Math.Sqrt(Math.Pow((4 - (-5)), 2) + Math.Pow(0 - 1, 2));
            Console.WriteLine("<ANSWER 3b> " + answer3b);
            double answer3c = Math.Sqrt(Math.Pow((-2 - (6)), 2) + Math.Pow((-6 - (-4)), 2));
            Console.WriteLine("<ANSWER 3c> " + answer3c);
            // Option to quit the program
            Console.Write("Press <ENTER> to quit...");
            Console.ReadLine();
        }
    }
}