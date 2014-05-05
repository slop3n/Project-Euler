using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=20

    static void Main(string[] args)
    {
        BigInteger sum = 1;
        for (int i = 1; i <= 100; i++)
        {
            sum *= i;
        }

        string sumAsString = sum.ToString();
        int totalsum = 0;

        for (int i = 0; i < sumAsString.Length; i++)
        {
            totalsum += (int)char.GetNumericValue(sumAsString[i]);
        }

        Console.WriteLine(totalsum);
    }
}

