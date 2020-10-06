using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problem");
            //Creating new Validate details instance
            ValidateDetails validateDetails = new ValidateDetails();
            while(true)
            {
                //Validating first name using ValidateFirstName Method
                validateDetails.ValidateFirstName();
                Console.WriteLine("Press Y to validate more details");
                //If user wants to exit
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    validateDetails.logger.Info("User chose to exit the application");
                    return;
                }
            }
           
        }
    }
}
