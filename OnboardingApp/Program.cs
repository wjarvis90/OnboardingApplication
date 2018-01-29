using System;


namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hello! Welcome to this onboarding application!");
            
            user.FirstName = AskQuestion("What is your first name?");
            user.LastName = AskQuestion("What is your last name?");

            Console.WriteLine("Hi! " + user.FirstName + " " + user.LastName + "!");
            Console.WriteLine("Again, welcome!");

            user.Email = AskQuestion("What is your email address?");

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner?");

            user.PassCode = AskQuestion("Please enter your passcode?");

            Console.ReadLine();
        }

        private static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                var response = AskQuestion(question + " yes/no");
                if (response.ToLower().Contains("yes"))
                {
                    return true;
                }
                if (response.ToLower().Contains("no"))
                {
                    return false;
                }
            }
        }
    }
}
