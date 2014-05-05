using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=48

    static void Main(string[] args)
    {
        BigInteger sum = 0;

        for (int i = 1; i < 1001; i++)
        {
            sum += Power(i, i);
        }

        string number = sum.ToString();
        Console.WriteLine(number);
        string result = "";
        for (int i = number.Length - 1; i >= number.Length - 10; i--)
        {
            result += number[i].ToString();
        }

        Console.WriteLine(result);
    }

    static BigInteger Power(int number, int power)
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