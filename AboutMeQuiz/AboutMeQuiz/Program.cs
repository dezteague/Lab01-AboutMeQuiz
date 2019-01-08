using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Deziree Teague Quiz!");

            //Question1
            Console.WriteLine("Can you guess my nickname?");
            string name = Console.ReadLine();
            //convert user input into lowercase
            string nickname = name.ToLower();
            QuestionOne(nickname);

            //Question2
            Console.WriteLine("How many countries have I visited?");
            string countries = Console.ReadLine();
            int countryguess = Convert.ToInt32(countries);
            QuestionTwo(countryguess);
        }

        static bool QuestionOne(string nickname)
        {
            if ((nickname == "dez") || (nickname == "dezi"))
            {
                Console.WriteLine("Yes, you're correct!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, incorrect.  My friends and family usually call me Dez or Dezi");
                return false;
            }
           
        }

        static void QuestionTwo (int countryguess)
        {  
            try
            {
                if ((countryguess > 36) || (countryguess < 36))
                {
                    Console.WriteLine("Not quite! I've been to 36 countries.  Traveling is one of my greatest passions!");
                }
                else
                {
                    Console.WriteLine("Wow, you're spot on!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect Format");
            }
        }
    }
}
