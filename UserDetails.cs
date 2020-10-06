using System;
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
        const string patternOfFirstName = "([A-Z]+)[a-zA-Z]{2,}";
        const string patternOfLastName = "([A-Z]+)[a-zA-Z]{2,}";

        //variables
        string firstName;
        string lastName;

        internal void userRegistration()
        {
            if (!ValidateFirstName()) return;
            if (!ValidateLastName()) return;
        }

       
        /// <summary>
        /// Validates the first name.
        /// </summary>
        private bool ValidateFirstName()
        {
            // User to input first Name
            Console.WriteLine("\nEnter the first name");
            firstName = Console.ReadLine();
            //If the first name is valid
            if (Regex.IsMatch(firstName, patternOfFirstName))
            {
                Console.WriteLine("\n{0} is a valid first name", firstName);
                logger.Info("User entered a valid first name");
                return true;
            }
            //If the first Name is invalid   
            else
            {
                logger.Warn("User entered invalid First Name");
                Console.WriteLine("\n{0} is not a valid first name.\nFirst name must start with capital and have minimum 3 characters",firstName);
                Console.WriteLine("Press Y to enter a valid First Name or other key to exit");
                //If user want to exit
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    Console.WriteLine("\nUser has choosen to exit.Thank You");
                    return false;
                }
                //If user wants to enter the name again
                return ValidateFirstName();
            }
        }

        private bool ValidateLastName()
        {
            Console.WriteLine("\nEnter the last name");
            lastName = Console.ReadLine();
            //If the first name is valid
            if (Regex.IsMatch(lastName, patternOfLastName))
            {
                Console.WriteLine("\n{0} is a valid last name", lastName);
                logger.Info("User entered a valid last name");
                return true;
            }
            //If the first Name is invalid   
            else
            {
                logger.Warn("User entered invalid last Name");
                Console.WriteLine("\n{0} is not a valid last name.\nLast name must start with capital and have minimum 3 characters", firstName);
                Console.WriteLine("Press Y to enter a valid Last Name or other key to exit");
                //If user want to exit
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    Console.WriteLine("\nUser has choosen to exit.Thank You");
                    return false;
                }
                //If user wants to enter the name again
                return ValidateLastName();
            }
        }

    }
}
