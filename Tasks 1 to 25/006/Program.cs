using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=6

    static void Main(string[] args)
    {
        long square = 0;
        long sum = 0;
        for (int i = 0; i < 101; i++)
        {
            square += (i * i);
            sum += i;
        }
        sum = sum * sum;

        Console.WriteLine(sum - square);
    }
}
