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
            //convert string to integer
            int countryguess = Convert.ToInt32(countries);
            //console.write line allows the correct answer to display to the user- see also question 3
            Console.WriteLine(QuestionTwo(countryguess));

            //Question3
            Console.WriteLine("What is my favorite fruit?");
            string favorite = Console.ReadLine();
            //convert user input into lowercase
            string favoriteFruit = favorite.ToLower();
            Console.WriteLine(QuestionThree(favoriteFruit));

            //Question4
            Console.WriteLine("How many siblings do I have?");
            string siblings = Console.ReadLine();
            //convert string to integer
            int siblingguess = Convert.ToInt32(siblings);
            QuestionFour(siblingguess);

            //Question5
            Console.WriteLine("What was my very first job as a teenager?");
            string job = Console.ReadLine();
            //convert user input to lowercase
            string firstJob = job.ToLower();
            QuestionFive(firstJob);
        }

        //return type: bool
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

        //return type int
        //this method will return correctcountries answer
        static int QuestionTwo (int countryguess)
        {  
            //try-catch block contains conditional if/else statement
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

        //return type string
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

        //return type void
        static void QuestionFour(int siblingguess)
        {
            if (siblingguess > 3)
            {
                Console.WriteLine("Sorry, you guessed too high.  I have 3 siblings");
            }
            if (siblingguess < 3)
            {
                Console.WriteLine("Sorry, you guessed too low.  I have 3 siblings");
            }
        }

        //return type void
        static void QuestionFive(string firstJob)
        {
            if (firstJob == "market researcher")
            {
                Console.WriteLine("Excellent guess.  You are correct!");
            }
            else
            {
                Console.WriteLine("Nope, my first job in high school was a market researcher!");
            }
        }
    }
}

//stretch goal: add counter to calculate and print the number of correct answers 
