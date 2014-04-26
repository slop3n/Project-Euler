using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

class Program
{
    //https://projecteuler.net/problem=13

    static void Main(string[] args)
    {
        string[] input = File.ReadAllLines(@"../../numbers.txt");
        BigInteger[] numbers = new BigInteger[input.Length];
        BigInteger sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = BigInteger.Parse(input[i]);
            sum += numbers[i];
        }

        Console.WriteLine(sum);
    }
}