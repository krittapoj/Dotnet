using System;

namespace Dotnetbegins;

    class program{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Loop ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Entered number is: {0}", n);
        } while (n != 0);
        Console.WriteLine("Finished");
    }
    }

    
