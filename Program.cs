using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i= 1; i <= 255; i++)
            Console.WriteLine(i);
            
            for(int x = 1; x <= 100; x++)
                if(x % 3 == 0 || x % 5 == 0)
            Console.WriteLine(x);
            
            for(int y = 1; y <= 100; y++)
            if(y % 3 == 0 && y % 5 == 0)
            Console.WriteLine("Fizz Buzz");
            else if(y % 3 == 0)
            Console.WriteLine("Fizz");
            else if(y % 5 == 0)
            Console.WriteLine("Buzz");
            else
            Console.WriteLine(y);
        }
    }
}
