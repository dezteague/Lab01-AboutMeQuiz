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
            //console.write line allows the correct answer to display to the user- see also question 3
            Console.WriteLine(QuestionTwo(countryguess));

            //Question3
            Console.WriteLine("What is my favorite fruit?");
            string favorite = Console.ReadLine();
            string favoriteFruit = favorite.ToLower();
            Console.WriteLine(QuestionThree(favoriteFruit));
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

        //this method will return correctcountries answer
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

        //this method will return correctFruit answer
        static string QuestionThree(string favoriteFruit)
        {
            string correctFruit = "mango";
            if (favoriteFruit == "mango")
            {
                Console.WriteLine("You got it! I love");
                return correctFruit;
            }
            else
            {
                Console.WriteLine("Sorry, incorrect.  I love tropical fruit. My favorite is: ");
                return correctFruit;
            }
        }

    }
}
