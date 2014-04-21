using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=5

    static void Main(string[] args)
    {
        ulong smallnum = 1;
        while (true)
        {
            if (smallnum % 2 == 0 && smallnum % 3 == 0 && smallnum % 4 == 0 && smallnum % 5 == 0 && smallnum % 6 == 0 &&
                smallnum % 7 == 0 && smallnum % 8 == 0 && smallnum % 9 == 0 && smallnum % 10 == 0 && smallnum % 11 == 0 &&
                smallnum % 12 == 0 && smallnum % 13 == 0 && smallnum % 14 == 0 && smallnum % 15 == 0 && smallnum % 16 == 0 &&
                smallnum % 17 == 0 && smallnum % 18 == 0 && smallnum % 19 == 0 && smallnum % 20 == 0)
            {
                if (smallnum % 2 == 0)
                {
                    Console.WriteLine(smallnum);
                    break;
                }
            }

            smallnum++;
        }
    }
}