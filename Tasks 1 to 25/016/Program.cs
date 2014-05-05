using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=16

    static void Main(string[] args)
    {
        int sum = 0;
        BigInteger number = Power(2, 1000);
        string numAsString = number.ToString();
        for (int i = 0; i < numAsString.Length; i++)
        {
            sum += (int)char.GetNumericValue(numAsString[i]);
        }
        Console.WriteLine(sum);
    }

    public static BigInteger Power(int number, int power)
    {
        int currentPow = 1;
        BigInteger result = 1;
        while (power >= currentPow)
        {
            result *= number;
            currentPow++;
        }

        return result;
    }
}
