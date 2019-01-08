using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1();
            Console.ReadLine();

        }
        //Console.WriteLine("what is my favorite color");
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
    }
}
