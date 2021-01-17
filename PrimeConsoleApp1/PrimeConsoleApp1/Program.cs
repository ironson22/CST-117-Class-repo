using System;

namespace PrimeConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheight = 100;

            celsius = (fahrenheight-32) * 5 / 9;


            Console.WriteLine("The Celsuis Equivelent is :" + celsius);
        }
    }
}
