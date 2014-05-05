using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=25

    static void Main(string[] args)
    {
        int lenght = 0;
        BigInteger firstNum = 1;
        BigInteger secondNum = 1;
        BigInteger sum = 0;
        int term = 2;
        while (lenght < 1000)
        {
            sum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = sum;
            string numAsString = sum.ToString();
            lenght = numAsString.Length;
            term++;
        }
        Console.WriteLine(sum);
        Console.WriteLine(term);
    }
}