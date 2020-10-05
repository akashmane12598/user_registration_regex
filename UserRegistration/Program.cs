using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            string fname, lname;
            string name_regex;
            while (true)
            {         
                Console.WriteLine("Enter your first name(only first letter in CAPS): ");
                fname = Console.ReadLine();
                name_regex = @"^[A-Z]{1}[a-z]{2,}";
                if (Regex.IsMatch(fname, name_regex))
                {
                    Console.WriteLine("Valid First Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter your last name(only first letter in CAPS): ");
                lname = Console.ReadLine();
                name_regex = @"^[A-Z]{1}[a-z]{2,}";
                if (Regex.IsMatch(lname, name_regex))
                {
                    Console.WriteLine("Valid Last Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                }
            }
            Console.WriteLine("Your Valid Entered Name is "+fname+" "+lname);
        }
    }
}
