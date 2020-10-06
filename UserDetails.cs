using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using NLog;


namespace UserRegistration
{
    public class UserDetails
    {
        public readonly Logger logger = LogManager.GetCurrentClassLogger();

        //constants
        const string patternOfFirstName = "^([A-Z]+)[a-zA-Z]{2,}$";
        const string patternOfLastName = "^([A-Z]+)[a-zA-Z]{2,}$";
        const string patternOfEmail = "^[a-zA-Z]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
        const string patternOfMobile = "^[0-9]{2}[ ][0-9]{10}$";
        const string patternOfPassword = "^(=?.*[A-Z]).{8,}$";
        //variables
        public string firstName;
        public string lastName;
        public string email;
        public string mobileNum;
        public string password;

        internal void userRegistration()
        {
            // User to input first Name
            Console.WriteLine("\nEnter the first name");
            firstName = Console.ReadLine();
            //if first name is invalid then exit
            if (!ValidateFormat(firstName, patternOfFirstName)) return;
            logger.Info("User entered a valid first name");
            //user to input last name
            Console.WriteLine("\nEnter the last name");
            lastName = Console.ReadLine();
            //if last name is invalid then exit
            if (!ValidateFormat(lastName, patternOfLastName)) return;
            logger.Info("User entered a valid last name");
            //user to input email
            Console.WriteLine("\nEnter the Email");
            email = Console.ReadLine();
            //if email is invalid
            if (!ValidateFormat(email,patternOfEmail)) return;
            logger.Info("User entered a valid Email");
            Console.WriteLine("User Registration Successful");
            //User to input mobile number
            Console.WriteLine("\nEnter the mobile number");
            mobileNum = Console.ReadLine();
            //if mobile number is invalid
            if (!ValidateFormat(mobileNum, patternOfMobile)) return;
            logger.Info("User entered a valid mobile number");
            //User to input Password
            Console.WriteLine("\nEnter the password");
            password = Console.ReadLine();
            //if password is invalid
            //if (password.Length >= 8)
            //{
              if(!ValidateFormat(password, patternOfPassword)) return;
            //}
            logger.Info("User entered a validpassword");
            Console.WriteLine("User Registration Successful");

        }
        /// <summary>
        /// Validates the first name.
        /// </summary>
        private bool ValidateFormat(string userEntry, string pattern)
        {
            //If the first name is valid
            if (Regex.IsMatch(userEntry, pattern))
            {
                Console.WriteLine("\n{0} is in valid format", userEntry);
                return true;
            }
            //If the first Name is invalid   
            else
            {
                logger.Warn("User entry is in invalid Format");
                Console.WriteLine("\nThe entered format is invalid");
                if (!DisplayFormat(pattern)) return false;
                return true;
            }
        }
        /// <summary>
        /// Displays the format.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        private bool DisplayFormat(string pattern)
        {
            if (pattern == patternOfFirstName)
            {
                Console.WriteLine("Name must start with capital and have minimum 3 characters");
                if (!TryAgain()) return false;
                //If user wants to enter the name again
                Console.WriteLine("\nEnter the name");
                firstName = Console.ReadLine();
                return ValidateFormat(firstName, pattern);
            }

            else if (pattern == patternOfLastName)
            {
                Console.WriteLine("Name must start with capital and have minimum 3 characters");
                if (!TryAgain()) return false;
                //If user wants to enter the name again
                Console.WriteLine("\nEnter the name");
                lastName = Console.ReadLine();
                return ValidateFormat(lastName, pattern);
            }

            else if (pattern == patternOfEmail)
            {
                Console.WriteLine("Make sure that @ and . are in correct positions");
                if (!TryAgain()) return false;
                //If user wants to enter the name again
                Console.WriteLine("\nEnter the email");
                email = Console.ReadLine();
                return ValidateFormat(email, pattern);
            }

            else if (pattern == patternOfMobile)
            {
                Console.WriteLine("Make sure that you enter country code and space then mobile number");
                if (!TryAgain()) return false;
                //If user wants to enter the name again
                Console.WriteLine("\nEnter the mobile number");
                email = Console.ReadLine();
                return ValidateFormat(email, pattern);
            }
            else if (pattern == patternOfPassword)
            {
                Console.WriteLine("Make sure there are atleast 8 characters, one capital letter");
                if (!TryAgain()) return false;
                //If user wants to enter the name again
                Console.WriteLine("\nEnter the password");
                password = Console.ReadLine();
                return ValidateFormat(password, pattern);
            }
            return false;
        }
        /// <summary>
        /// Tries the again.
        /// </summary>
        /// <returns></returns>
        private bool TryAgain()
        {
            Console.WriteLine("Press Y to enter again or other key to exit");
            //If user want to exit
            if (Console.ReadLine().ToUpper() != "Y")
            {
                Console.WriteLine("\nUser has choosen to exit.Thank You");
                return false;
            }
            return true;
        }

    }      
}
