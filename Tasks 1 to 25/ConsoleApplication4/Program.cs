using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string numberAsString;
            int maxNum = 0;
            bool palindrome = true;
            for (int i = 0; i < 1000; i++)
            {
                for (int k = 0; k < 1000; k++)
                {
                    number = i * k;
                    numberAsString = number.ToString();
                    palindrome = true;
                    for (int t = 0; t < numberAsString.Length / 2; t++)
                    {
                        if (numberAsString[t] != numberAsString[numberAsString.Length - 1 - t])
                        {
                            palindrome = false;
                        }
                    }
                    
                    if (palindrome)
                    {
                        if (int.Parse(numberAsString) > maxNum)
                        {
                            maxNum = int.Parse(numberAsString);
                            Console.WriteLine(maxNum);

                        }
                    }
                }
            }
        }
    }
}
