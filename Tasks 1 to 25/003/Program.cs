using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=3

    static void Main(string[] args)
    {
        long num = 600851475143;
        for (int i = 1; i < num / 2; i++)
        {
            if (num % i == 0)
            {
                if (isPrime(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    public static bool isPrime(int number)
    {
        double boundary = Math.Floor(Math.Sqrt(number));

        if (number == 1)
        {
            return false;
        }
        if (number == 2)
        {
            return true;
        }

        for (int i = 2; i <= boundary; ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}