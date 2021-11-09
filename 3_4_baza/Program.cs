using System;

namespace _3_4_baza
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("|           x           |           y           |");
                for (double x = 1.1; x <= 2.9; x += 0.2)
                {
                    double y = 0.25 * Math.Pow(x, 3) - 2.8 * x - 2;
                    Console.WriteLine($"|{x}|{y:F2}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
