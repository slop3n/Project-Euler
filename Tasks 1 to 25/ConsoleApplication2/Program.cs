using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=2

    static void Main(string[] args)
    {
        var list = new List<long>();

        long fourMil = 4000000;
        long sum = 0;
        list.Add(1);
        list.Add(2);

        for (int i = 2; i < 50; i++)
        {
            list.Add(list[i - 1] + list[i - 2]);
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < fourMil && list[i] % 2 == 0)
            {
                sum += list[i];
            }
        }
        Console.WriteLine(sum);
    }
}