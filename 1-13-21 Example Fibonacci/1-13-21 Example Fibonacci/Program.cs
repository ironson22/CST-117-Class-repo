using System;

namespace _1_13_21_Example_Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)//this is a declaration of a function and a integar called "n"
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            // int x = 0, y = 1;//compute 10 fibonacci numbers

            // for (int i = 0; i < n; i++)//this will loop until the variable i is equal to the integar n
            // {
            // int temp = x;
            // x = y;
            // y = temp + y;
            // }
            // return x;

        }
        public static void Main()
        {
            Console.WriteLine("Please enter a number of sequence you would like to find:");
            int valueSeq = int.Parse(Console.ReadLine());
            int m = valueSeq;
            if (m < 0)
                Console.Write("Fibonacci number is not defined");
            else
                Console.Write(Fibonacci(m));
            //    for (int i = 0; i < 10; i++) {
            //        Console.WriteLine(Fibonacci(i));//this line called the function that was created above that was given a parameter that is created from the for loop
            //   }
        }
    }
}
