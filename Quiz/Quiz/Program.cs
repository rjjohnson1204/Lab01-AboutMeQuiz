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
        static int Q2()
        {
            Console.WriteLine("Is my favorite color red?");

            bool answer = Convert.ToUpper(Console.ReadLine();

            if (answer == "BLUE")
            {
                Console.WriteLine("False");
            }

            else
            {
                Console.WriteLine("True");
            }
            return answer;

        }
    }

}
