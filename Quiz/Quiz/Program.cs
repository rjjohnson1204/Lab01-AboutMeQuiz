using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old am I?");
            Console.Read();
            int answer = Convert.ToInt32(Console.Read());
            
                if (answer == 34)
            {
                Console.WriteLine("Correct!");
            }
            
            else 
            { 
                Console.WriteLine("Not even close!");
            }
           


        }
        //Console.WriteLine("what is my favorite color");
    }
}
