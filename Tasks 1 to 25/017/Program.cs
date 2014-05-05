using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //https://projecteuler.net/problem=17

    static void Main(string[] args)
    {
        int lenght = 0;
        for (int i = 1; i < 1000; i++)
        {
            string number = i.ToString();

            if (number.Length >= 1 && (i < 10 || i > 19))
            {
                switch (number[0])
                {
                    case '1': lenght += 3; break;
                    case '2': lenght += 3; break;
                    case '3': lenght += 5; break;
                    case '4': lenght += 4; break;
                    case '5': lenght += 4; break;
                    case '6': lenght += 3; break;
                    case '7': lenght += 5; break;
                    case '8': lenght += 5; break;
                    case '9': lenght += 4; break;
                }
            }

            if (number.Length == 2 && i > 19)
            {
                switch (number[0])
                {
                    case '2': lenght += 6; break;
                    case '3': lenght += 6; break;
                    case '4': lenght += 5; break;
                    case '5': lenght += 6; break;
                    case '6': lenght += 5; break;
                    case '7': lenght += 6; break;
                    case '8': lenght += 6; break;
                    case '9': lenght += 6; break;
                }
                switch (number[1])
                {
                    case '1': lenght += 3; break;
                    case '2': lenght += 3; break;
                    case '3': lenght += 5; break;
                    case '4': lenght += 4; break;
                    case '5': lenght += 4; break;
                    case '6': lenght += 3; break;
                    case '7': lenght += 5; break;
                    case '8': lenght += 5; break;
                    case '9': lenght += 4; break;
                }
            }

            if (number.Length == 2 && i < 20)
            {
                switch (number)
                {
                    case "10": lenght += 3; break;
                    case "11": lenght += 6; break;
                    case "12": lenght += 6; break;
                    case "13": lenght += 8; break;
                    case "14": lenght += 8; break;
                    case "15": lenght += 8; break;
                    case "16": lenght += 7; break;
                    case "17": lenght += 9; break;
                    case "18": lenght += 9; break;
                    case "19": lenght += 8; break;
                }
            }
        }
        Console.WriteLine(lenght);
    }
}