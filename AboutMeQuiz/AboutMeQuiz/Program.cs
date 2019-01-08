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
    }
}
