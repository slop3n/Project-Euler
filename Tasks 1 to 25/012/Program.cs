using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=12

    static void Main(string[] args)
    {
        int number = 0;
        int i = 1;

        while (NumberOfDivisors(number) < 500)
        {
            number += i;
            i++;
        }
        Console.WriteLine(number);
    }

    public static int NumberOfDivisors(int number)
    {
        int divisors = 0;
        int sqrt = (int)Math.Sqrt(number);

        for (int i = 1; i <= sqrt; i++)
        {
            if (number % i == 0)
            {
                divisors += 2;
            }
        }

        if (sqrt * sqrt == number)
        {
            divisors--;
        }
    
        return divisors;
    }
}