using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeList = new List<long>();
            
            long limit = 2000000;

            for (var i = 2; i < limit; i++)
            {
                if (IsPrime(i)) primeList.Add(i);
            }
            
            Console.WriteLine(GetSum(primeList));
        }

        private static long GetSum(IEnumerable<long> list)
        {
            return list.Sum();
        }

        private static bool IsPrime(Int64 number)
        {
            Int64 i = 2;

            if (number == 2) return true;

            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0) return false;
                i++;
            }

            return true;
        }
    }
}