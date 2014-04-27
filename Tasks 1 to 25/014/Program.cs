using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=14
    //kinda slow and brute force but i like it, its also very simple

    static void Main(string[] args)
    {
        int maxCounter = 1;
        var numbers = new List<ulong>();
        for (ulong i = 1; i < 1000000; i++)
        {
            numbers = Sequence(i);
            if (numbers.Count > maxCounter)
            {
                maxCounter = numbers.Count;
                Console.WriteLine(i);
                Console.WriteLine(maxCounter);
            }
        }
    }

    public static List<ulong> Sequence(ulong number)
    {
        var list = new List<ulong>();
        while (!(number == 1))
        {
            if (number % 2 == 0)
            {
                number = number / 2;
                list.Add(number);
            }
            else
            {
                number = number * 3 + 1;
                list.Add(number);
            }
        }

        return list;
    }
}