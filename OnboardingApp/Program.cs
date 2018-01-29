using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to this onboarding application?");

            var user = new user();

            user.FirstName = AskQuestion("What is your first name?");
            user.LastName = AskQuestion("What is your last name?");

            Console.WriteLine("Hi! " + user.FirstName + user.LastName + "!");
            Console.WriteLine("Again, welcome!");
        }

        private static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
