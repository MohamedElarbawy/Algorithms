using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Recursion
    {
        public static void CountDown(int number)
        {
            Console.Write($"{number}, ");
            number -= 1;
            if (number >= 0)
            {
                CountDown(number);
            }

        }

        public static int Factorial(int x)
        {
            if (x <= 1) return 1;

            return x * Factorial(x - 1);
        }




        public static void GenerateFibonacciSeries(int firstNumber, int secondNumber, int i, int lengthOfSeies)
        {
            if (i <= lengthOfSeies)
            {
                Console.Write($"{firstNumber}, ");
                GenerateFibonacciSeries(secondNumber, firstNumber + secondNumber, ++i, lengthOfSeies);
            }

        }

        // using equation F(n) = F(n-1) + F(n-2)
        //to use this function you have to call this functoin in a loop and pass the index of the loop as a parameter
        public static int GenerateFibonacciSeries( int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
                
            return GenerateFibonacciSeries(n - 1)+GenerateFibonacciSeries(n-2);

        }

    }
}
