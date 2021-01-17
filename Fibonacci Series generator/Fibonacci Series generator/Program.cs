using System;

namespace Fibonacci_Series_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author: Vincent Sanchez
            //Filename: Fibonacci series generator
            //Date: 1-13-21
            int n1 = 0, n2 = 1, n3, i, number;//this line declares the global integers that we will be using throughout this console app
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
