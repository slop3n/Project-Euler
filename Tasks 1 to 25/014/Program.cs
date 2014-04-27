using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=14

    static void Main(string[] args)
    {
        int maxCounter = 1;
        for (int i = 2; i < 1000000; i++)
        {
            int number = i;
        }
        Console.WriteLine(maxCounter);
    }

    public int Sequence(int number)
    {
        int counter = 1;
        while (!(number == 1))
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = number * 3 + 1;
            }
            counter++;
        }

        return counter;
    }
}