using System;

namespace HelloWorld
{
  class Program
  {
        static void Main(string[] args)
        {
            Random number = new Random();
            int winNum = number.Next(0, 100);

            bool win = false;
            do
            {
                Console.Write("Guess a number inbetween 0 and 100: ");
                string inkey = Console.ReadLine();

                int num1 = int.Parse(inkey);

                if (num1 > winNum)
                {
                    Console.Write("To high! Gusse Lower...");
                }
                else if (num1 < winNum)
                {
                    Console.Write("To Low! Gusse Higher");
                }
                else if (num1 == winNum)
                {
                    Console.Write("You Win !");
                    win = true;
                }
            } while (win == false);

        }
  }
}
