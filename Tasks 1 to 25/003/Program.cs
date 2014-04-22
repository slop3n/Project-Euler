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
                if (IsPrime(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number % 2 == 0)
        {
            if (number == 2)
            {
                return true;
            }
            return false;
        }

        int max = (int)Math.Sqrt(number);
        for (int i = 3; i <= max; i += 2)
        {
            if ((number % i) == 0)
            {
                return false;
            }
        }
        return true;
    }
}