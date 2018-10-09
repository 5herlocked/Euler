using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Euler13
{
    static class Program
    {
        private const string Path = "euler13.txt";
        private static Stopwatch _time;

        public static void Main(string[] args)
        {
            _time = Stopwatch.StartNew();
            
            var list = new List<BigInteger>();
            
            var fileReader = new FileStream(Path, FileMode.Open,FileAccess.Read);
            var matrix = new StreamReader(fileReader);

            while (!matrix.EndOfStream)
            {
                list.Add(BigInteger.Parse(matrix.ReadLine() ?? throw new Exception("Null String in file")));
            }
            
            Console.WriteLine(list.Aggregate((currentSum, item) => currentSum + item));
            Console.WriteLine(_time.Elapsed);
            _time.Stop();
            Console.ReadLine();
        }
    }
}