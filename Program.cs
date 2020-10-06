using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problem");
            //Creating new Validate details instance
            UserDetails userDetails = new UserDetails();
            while(true)
            {
                //Validating first name using ValidateFirstName Method
                userDetails.userRegistration();
                Console.WriteLine("Press Y to validate more details");
                //If user wants to exit
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    userDetails.logger.Info("User chose to exit the application");
                    return;
                }
            }
           
        }
    }
}
