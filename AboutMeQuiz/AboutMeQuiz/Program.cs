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
            Console.WriteLine(QuestionTwo(countryguess));
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

        static int QuestionTwo (int countryguess)
        {  
            try
            {
                int correctcountries = 36;
                if ((countryguess > correctcountries) || (countryguess < correctcountries))
                {
                    Console.WriteLine("Not quite! Traveling is one of my greatest passions!  Here's the correct number: ");
                    return correctcountries;
                }
                else
                {
                    Console.WriteLine("Wow, you're spot on!");
                    return correctcountries;
                }
            }
            //this exception notifies the user to provide numeric input 
            catch (FormatException)
            {
                Console.WriteLine("Incorrect Format");
            }
            return 0;
        }
    }
}
