using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            string fname, lname,email,phone_no,password;
            string name_regex;
            string regex_email;
            string phone_no_regex;
            string password_regex;
            while (true)
            {         
                Console.WriteLine("Enter your first name(only first letter in CAPS): ");
                fname = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(fname);

                name_regex = @"^[A-Z]{1}[a-z]{2,}$";
                Regex regex = new Regex(name_regex);

                var result1 = list.TrueForAll(fname=>regex.Match(fname).Success);

                if (result1)
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
                List<string> list = new List<string>();
                list.Add(lname);

                name_regex = @"^[A-Z]{1}[a-z]{2,}$";
                Regex regex = new Regex(name_regex);

                bool result1 = list.TrueForAll(lname => regex.Match(lname).Success);

                if (result1)
                {
                    Console.WriteLine("Valid Last Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                }
            }
            
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                email = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(email);

                regex_email = @"^[A-Za-z]+[.+-]?[a-z]*[@][A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2})?$";
                Regex regex = new Regex(regex_email);

                bool result = list.TrueForAll(email=>regex.Match(email).Success);
                if (result)
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
                List<string> list = new List<string>();
                list.Add(phone_no);

                phone_no_regex = @"^[+0-9]{2,}[\s]{1}[0-9]{10}$";
                Regex regex = new Regex(phone_no_regex);

                bool result = list.TrueForAll(phone_no=>regex.Match(phone_no).Success);

                if (result)
                {
                    Console.WriteLine("Valid Phone Number: "+phone_no);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                }
            }
            while (true)
            {
                Console.WriteLine("Set a password: ");
                password = Console.ReadLine();
                List<string> list = new List<string>();
                list.Add(password);

                password_regex = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^@$!%*^#?&]*[@$!%*^#?&][^@$!%^*#?&]*$).{8,}$";
                Regex regex = new Regex(password_regex);

                bool result = list.TrueForAll(password=>regex.Match(password).Success);

                if (result)
                {
                    Console.WriteLine("Password set Successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter password again");
                }
            }
            Console.WriteLine("Your Valid Entered Name is " + fname + " " + lname);
            Console.WriteLine("Your Valid Entered Email-Id is " + email);
            Console.WriteLine("Your Valid Entered Phone Number is " + phone_no);
        }
    }
}
