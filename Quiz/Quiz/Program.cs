using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {   // calling Q1
            Q1();
            //taking in input from user
            Console.ReadLine();
            // calling Q2
            Q2();
            //taking in input from user
            Console.ReadLine();
            // calling Q3
            Q3();
            //taking in input from user
            Console.ReadLine();
            // calling Q4
            Q4();
            //taking in input from user
            Console.ReadLine();
            // calling Q1
            Q5();
            //taking in input from user
            Console.ReadLine();


        } //Q1 method
        static int Q1()
        { //ask question to user
            Console.WriteLine("How old am I?");

            //converts string to int
            int answer = Convert.ToInt32(Console.ReadLine());
            // answer
            if (answer == 34)
            { //correct response
                Console.WriteLine("Correct!");
            }

            else
            {   //response if incorrect answer is given
                Console.WriteLine("Not even close!");
            }
            return answer;

        } //Q2 method
        static string Q2()
        {
            //ask question to user
            Console.WriteLine("What is my favorite Color?");
            // takes in input from user
            String answer = Console.ReadLine();
            // converts to upper case
            String colorAnswer = (answer.ToUpper());
            // correct answer
            if (colorAnswer == "BLUE")
            { // response for correct answer
                Console.WriteLine(" That is my favorite.");
            }

            else
            {   // response for incorrect answer
                Console.WriteLine(" That is not my favorite color.");
            }
            return colorAnswer;

        } //Q3 method
        static bool Q3()
        {
            //ask question to user
            Console.WriteLine("I have 3 cats? (true or false)");
            // takes in user input
            String answer = Console.ReadLine();
            // converts user input from string to boolean 
            bool petAnswer = (Convert.ToBoolean(answer));
            if (petAnswer == true)
            {  
                // response for incorrect answer

                Console.WriteLine("Incorrect, I have zero cats.");
            }

            else if (petAnswer == false)
            {
                // response for correct answer
                Console.WriteLine("Correct, I have zero cats.");
            }

            return petAnswer;

        } //Q4 method
        static bool Q4()
        {
            try
            {
                //ask question to user
                Console.WriteLine("I am from Washington? (true or false)");

                // takes in answer from user
                String answer = Console.ReadLine();
                // convers user input from string to boolean
                bool stateAnswer = (Convert.ToBoolean(answer));

                if (stateAnswer == true)
                { // response for incorrrect answer
                    Console.WriteLine("False! I am not from Washington.");
                }

                else if (stateAnswer == false)
                {  // response for correct answer
                    Console.WriteLine("Correct, I am from California.");
                }

                return stateAnswer;
            }
            catch
            {   // response if incorrect answer type is given (exception)
                Console.WriteLine("please answer True or False");

                Q4();
                return false;
            }
        } //Q5 method
        static string Q5()
        {
            try
            {
                //ask question to user
                Console.WriteLine("Do I like front end or back end?  (YES OR NO)");
                // takes in user response
                String answer = Console.ReadLine();
                // converts user response to upper case
                String typeAnswer = (answer.ToUpper());
                // response when  user provides correct answer
                if (typeAnswer == "YES")
                {
                    //the response the user will receive for the correct answer
                    Console.WriteLine(" Correct, I like front end.");
                }

                else
                { // the response the user will receive if the answer is incorrect
                    Console.WriteLine(" I do not like back end....I think.");
                }

                return typeAnswer;

            }
            catch (Exception e)
            {   // if an exception is encountered 
                Console.WriteLine(e.Message);
                Q5();
                return "waffles";
            }

            finally
            {  // end of Q5 "break" or "continue on"
                Console.WriteLine("fin");
            }

        }
    }
}

