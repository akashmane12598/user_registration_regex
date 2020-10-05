using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            Console.WriteLine("Enter your first name(only first letter in CAPS): ");
            string fname = Console.ReadLine();
            string name_regex = @"^[A-Z]{1}[a-z]{2,}";
            if (Regex.IsMatch(fname, name_regex))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }
    }
}
