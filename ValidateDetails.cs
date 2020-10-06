using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using NLog;

namespace UserRegistration
{
    public class ValidateDetails
    {
        public readonly Logger logger = LogManager.GetCurrentClassLogger();
        //constants
        string patternOfFirstName = "([A-Z]+)[a-zA-Z]{2,}";
        //variables
        string firstName;

        /// <summary>
        /// Validates the first name.
        /// </summary>
        public void ValidateFirstName()
        {
            // User to input first Name
            Console.WriteLine("\nEnter the first name");
            firstName = Console.ReadLine();
            //If the first name is valid
            if (Regex.IsMatch(firstName, patternOfFirstName))
            {
                Console.WriteLine("\n{0} is a valid first name", firstName);
                logger.Info("User entered a valid first name");
            }
            //If the first Name is invalid   
            else
            {
                logger.Warn("User entered invalid First Name");
                Console.WriteLine("\n{0} is not a valid first name.\nFirst name must start with capital and have minimum 3 characters",firstName);
                Console.WriteLine("Press Y to enter a valid First Name or other key to exit");
                if (Console.ReadLine().ToUpper() == "Y")
                    ValidateFirstName();
                Console.WriteLine("\nUser has choosen to exit.Thank You");
            }
        }
    }
}
