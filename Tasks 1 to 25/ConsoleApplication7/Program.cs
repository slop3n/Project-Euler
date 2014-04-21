using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=7

    static void Main(string[] args)
    {
        int i = 1;
        int counter = 0;
        while (counter < 10001)
        {
            if (isPrime(i))
            {
                Console.WriteLine(i);
                counter++;
            }
            i++;
        }
    }

    public static bool isPrime(int number)
    {
        double boundary = Math.Floor(Math.Sqrt(number));

        if (number == 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= boundary; ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
