using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1();
            Console.ReadLine();
            Q2();
            Console.ReadLine();
            Q3();
            Console.ReadLine();


        }
        static int Q1()
        {
            Console.WriteLine("How old am I?");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 34)
            {
                Console.WriteLine("Correct!");
            }

            else
            {
                Console.WriteLine("Not even close!");
            }
            return answer;
           
        }
        static string Q2()
        {
            Console.WriteLine("What is my favorite Color?");

            String answer = Console.ReadLine();

            String colorAnswer = (answer.ToUpper());

            if (colorAnswer == "BLUE")
            {
                Console.WriteLine(" That is my favorite.");
            }

            else
            {
                Console.WriteLine(" That is not my favorite color.");
            }
            return colorAnswer;

        }
        static bool Q3()
        {
            Console.WriteLine("I have an 3 cats? (true or false)");

            String answer = Console.ReadLine();

            bool petAnswer = (Convert.ToBoolean(answer));

            if (petAnswer == true)
            {
                Console.WriteLine("Incorrect, I have zero cats.");
            }

            else if ( petAnswer == false)
            {
                Console.WriteLine("Correct, I have zero cats.");
            }

            return petAnswer;









        }
    }

}
