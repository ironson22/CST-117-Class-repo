using System;

namespace _1_13_21_Example_Fibonacci
{
    class Program
    {
         public static int Fibonacci(int n)//this is a declaration of a function and a integar called "n"
        {
            
           int x = 0, y = 1;//compute 10 fibonacci numbers

           for (int i = 0; i < n; i++)//this will loop until the variable i is equal to the integar
           {
           int temp = x;
           x = y;
           y = temp + y;
           }
           return x;
           
        }
        static void Main()
        {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(Fibonacci(i));//this line called the function that was created above that was given a parameter that is created from the for loop
            }
        }
    }
}
