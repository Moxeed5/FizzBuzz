using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz1
{
    internal class Fizz
    {
        public static string FizzBuzz(int x)
        {
            string y = "fizz";
            string z = "buzz";
            string m = "fizzbuzz";

            if (x % 15 == 0)
            {
                Console.WriteLine(m);
                return m;
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine(z);
                return z;
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine(z);
                return z;
            }
            else
            {
                Console.WriteLine(x);
                return x.ToString();

            }
        }
    }
}
