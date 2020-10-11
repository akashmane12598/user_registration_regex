using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string fname, lname, email, phone_no, password;
        public static string name_regex;
        public static string regex_email;
        public static string phone_no_regex;
        public static string password_regex;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            //FirstNameRegex();
            
            Console.WriteLine("Your Valid Entered Name is " + fname + " " + lname);
            Console.WriteLine("Your Valid Entered Email-Id is " + email);
            Console.WriteLine("Your Valid Entered Phone Number is " + phone_no);
        }
        public Boolean FirstNameRegex()
        {
            while (true)
            {
                Console.WriteLine("Enter your first name(only first letter in CAPS): ");
                fname = "Akash";
                name_regex = @"^[A-Z]{1}[a-z]{2,}$";
                if (Regex.IsMatch(fname, name_regex))
                {
                    Console.WriteLine("Valid First Name");
                    return true;
                    
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                    return false;
                }
            }
        }

        public Boolean LastNameRegex()
        {
            while (true)
            {
                Console.WriteLine("Enter your last name(only first letter in CAPS): ");
                lname = "Mane";
                name_regex = @"^[A-Z]{1}[a-z]{2,}$";
                if (Regex.IsMatch(lname, name_regex))
                {
                    Console.WriteLine("Valid Last Name");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                    return false;
                }
            }
        }

        public Boolean EmailId()
        {
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                email = "akash.mane@spit.ac.in";
                regex_email = @"^[A-Za-z]+[.+-]?[a-z]*[@][A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2})?$";
                if (Regex.IsMatch(email, regex_email))
                {
                    Console.WriteLine("Valid Email-Id: " + email);
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Email-Id");
                    return false;
                }
            }
        }
        
        public Boolean PhoneNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter the Valid Phone Number: ");
                phone_no = "+91 0123456789";
                phone_no_regex = @"^[+0-9]{2,}[\s]{1}[0-9]{10}$";
                if (Regex.IsMatch(phone_no, phone_no_regex))
                {
                    Console.WriteLine("Valid Phone Number: " + phone_no);
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                    return false;
                }
            }
        }

        public Boolean Password()
        {
            while (true)
            {
                Console.WriteLine("Set a password: ");
                password = "Axdcs55@gfS";
                password_regex = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^@$!%*^#?&]*[@$!%*^#?&][^@$!%^*#?&]*$).{8,}$";
                if (Regex.IsMatch(password, password_regex))
                {
                    Console.WriteLine("Password set Successfully");
                    return true;
                }
                else
                {
                    Console.WriteLine("Enter password again");
                    return false;
                }
            }
        }
    }
}
