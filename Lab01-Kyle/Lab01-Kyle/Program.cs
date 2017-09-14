using System;
using System.Linq;
namespace Lab01_Kyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play A Game!");
            //QuestionOne();
            //QuestionTwo();
            CorrectAnswerTotal();
            Console.Read();
        }


        static int QuestionOne()

        {
            Console.WriteLine("What State was I born in? I am going to be nice and give you 3 guesses.");
            int AnswerCounter = 0;
            string[] CorrectAnswer = new string[] { "indiana" };

            for (int i = 0; i < 3; i++)
            {
                string response = Console.ReadLine().ToLower();
                if (CorrectAnswer.Contains(response))
                {
                    Console.WriteLine("You are Correct! I was born in Indiana.");
                    AnswerCounter++;
                    i = 3;
                }
                else if (!CorrectAnswer.Contains(response))
                {
                    if (i == 2)
                    {
                        Console.WriteLine("I am sorry, you are out of guesses.");
                    }
                    else
                    {
                    Console.WriteLine("Sorry please try again!");
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid response!");
                    i--;
                }

            }
            return AnswerCounter;

        }
        static int QuestionTwo()

        {
            Console.WriteLine("Do you think I like Star Trek? Yes or No");
            string[] CorrectAnswer = new string[] { "no", "n" };
            int AnswerCounter = 0;
            string response = Console.ReadLine().ToLower();
            if (CorrectAnswer.Contains(response))
            {
                Console.WriteLine("You are Correct! I am a Star Wars fan.");
                AnswerCounter++;
            }
            else
            {
                Console.WriteLine("I am sorry that is not correct. I am a Star Wars fan.");
            }

            return AnswerCounter;
        }
        static void CorrectAnswerTotal()
        {
            int correctAnswerTotal = 0;
            correctAnswerTotal += QuestionOne(); 
            correctAnswerTotal += QuestionTwo();
            correctAnswerTotal += QuestionThree();

            Console.WriteLine($"You got {correctAnswerTotal} Correct!");
            //needed a change to commit branch
        }

        static int QuestionThree()
        {

            Console.WriteLine("Can you guess my favorite number?");
            int AnswerCounter = 0;
            int CorrectAnswer = 27;
            int response = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (CorrectAnswer == response)
                {
                    Console.WriteLine("Way to go, You got it!");
                    AnswerCounter++;
                }
                else if (CorrectAnswer != response)
                {
                    Console.WriteLine("I am sorry the correct answer is 27.");
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Please enter a number!");
                QuestionThree();
            }
            return AnswerCounter;
        }

        static int QuestionFour()
        {
            Console.WriteLine("Did you enjoy my quiz?");
            string[] CorrectAnswer = new string[] { "No", "N" };
            string response = Console.ReadLine().ToLower();
            int AnswerCounter = 0;

            try
            {
                if (CorrectAnswer.Contains(response))
                {
                    Console.WriteLine("I am glad you enjoyed");
                    AnswerCounter++;
                }
                else
                {
                    Console.WriteLine("I am sorry you didn't enjoy my quiz.");
                }
            }
            finally {
                Console.WriteLine("Fine Be that way!");
            }
        return AnswerCounter;
        }
    }
}