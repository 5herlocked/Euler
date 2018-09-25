using System;
using System.Collections.Generic;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int64> primeList = new List<Int64>();
            
            Int64 limit = 2000000;

            for (Int64 i = 2; i < limit; i++)
            {
                if (IsPrime(i)) primeList.Add(i);
            }
            
            Console.WriteLine(GetSum(primeList));
        }

        private static Int64 GetSum(List<Int64> list)
        {
            Int64 sum = 0;
            
            foreach (var n in list)
            {
                sum += n;
            }

            return sum;
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