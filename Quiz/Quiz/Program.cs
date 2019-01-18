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
            Q4();
            Console.ReadLine();
            Q5();
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
            Console.WriteLine("I have 3 cats? (true or false)");

            String answer = Console.ReadLine();

            bool petAnswer = (Convert.ToBoolean(answer));

            if (petAnswer == true)
            {
                Console.WriteLine("Incorrect, I have zero cats.");
            }

            else if (petAnswer == false)
            {
                Console.WriteLine("Correct, I have zero cats.");
            }

            return petAnswer;

        }
        static bool Q4()
        {
            try
            {

                Console.WriteLine("I am from Washington? (true or false)");

                String answer = Console.ReadLine();

                bool stateAnswer = (Convert.ToBoolean(answer));

                if (stateAnswer == true)
                {
                    Console.WriteLine("False! I am not from Washington.");
                }

                else if (stateAnswer == false)
                {
                    Console.WriteLine("Correct, I am from California.");
                }

                return stateAnswer;
            }
            catch
            {
                Console.WriteLine("please answer True or False");
                Q4();

                return false;
            }
        }
        static string Q5()
        {
            try
            {

                Console.WriteLine("Do I like front end or back end?  (YES OR NO");

                String answer = Console.ReadLine();

                String typeAnswer = (answer.ToUpper());

                if (typeAnswer == "YES")
                {
                    Console.WriteLine(" Correct, I like front end.");
                }

                else
                {
                    Console.WriteLine(" I do not like back end....I think.");
                }

                return typeAnswer;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Q5();
                return "waffles";
            }

            finally
            {
                Console.WriteLine("fin");
            }

        }
    }
}

