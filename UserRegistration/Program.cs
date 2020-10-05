﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            string fname, lname,email,phone_no;
            string name_regex;
            string regex_email;
            string phone_no_regex;
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
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                email = Console.ReadLine();
                regex_email = @"^[A-Za-z]+[\w.+-]*[@][A-Za-z0-9]+[.][a-z]{2,}[.]?[a-z]*$";
                if (Regex.IsMatch(email, regex_email))
                {
                    Console.WriteLine("Valid Email-Id: "+email);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Email-Id");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter the Valid Phone Number: ");
                phone_no = Console.ReadLine();
                phone_no_regex = @"^[+0-9]{2,}[\s]{1}[0-9]{10}$";
                if (Regex.IsMatch(phone_no, phone_no_regex))
                {
                    Console.WriteLine("Valid Phone Number: "+phone_no);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                }
            }
        }
    }
}
