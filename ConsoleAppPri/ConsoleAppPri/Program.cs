using System;

namespace ConsoleAppPri
{
    class Program
    {
        static void Main(string[] args)
        {
          //Console.WriteLine("Happy Friday, Please enter a number to test if it is prime: ");
          //int inputNumber = int.Parse(Console.ReadLine());
            bool YesPrime = true;
            for (int i = 2; i <= 100; i++)
            {
                for(int j = 2; j<=100; j++)
                {
                    if(i != j && i % j == 0)
                    {
                        YesPrime = false;
                        break;
                    }
                }
                if (YesPrime)
                {
                    Console.WriteLine("\t" + i);
                }
                YesPrime = true;
            }
        }
    }
}
