﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=9

    static void Main(string[] args)
    {
        bool found = false;
        for (int a = 1; a < 1000; a++)
        {

            for (int b = 1; b < 1000; b++)
            {

                for (int c = 1; c < 1000; c++)
                {

                    if (a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && a < b && b < c)
                    {
                        Console.WriteLine(a * b * c);
                        found = true;
                    }
                }
            }
        }
    }
}

