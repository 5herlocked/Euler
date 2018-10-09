using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Euler11
{
    static class Program
    {
        private static readonly string Path = "euler11.txt";
        private static List<string[]> _grid = new List<string[]>();
        private static List<List<int>> _intGrid = new List<List<int>>();
        private static Stopwatch _time;

        private static void Main(string[] args)
        {

            _time = Stopwatch.StartNew();
            
            var fileReader = new FileStream(Path, FileMode.Open,FileAccess.Read);
            var matrix = new StreamReader(fileReader);

            while (!matrix.EndOfStream)
            {
                _grid.Add(matrix.ReadLine()?.Split(" "));
            }

            foreach (var line in _grid)
            {
                var toAdd = line.Select(int.Parse).ToList();
                _intGrid.Add(toAdd);
            }

            long max = 1;

            for (var i = 0; i < 16;  i++)
            {
                for (var j = 0; j < 16; j++)
                {
                    var maxCurrent = GetMaxProd(i, j);

                    max = (maxCurrent > max) ? maxCurrent : max;
                }
            }
            
            Console.WriteLine(max);
            Console.WriteLine(_time.ElapsedMilliseconds);
            _time.Stop();
            Console.ReadLine();
        }

        private static long GetMaxProd(int i, int j)
        {
            var prods = new List<long>
            {
                _intGrid[i][j] * _intGrid[i + 1][j] * _intGrid[i + 2][j] * _intGrid[i + 3][j],
                _intGrid[i][j] * _intGrid[i][j + 1] * _intGrid[i][j + 2] * _intGrid[i][j + 3],
                _intGrid[i][j] * _intGrid[i + 1][j + 1] * _intGrid[i + 2][j + 2] * _intGrid[i + 3][j + 3],
                _intGrid[19 - i][j] * _intGrid[18 - i][j + 1] * _intGrid[17 - i][j + 2] *
                _intGrid[16 - i][j + 3]
            };

            return prods.Max();
        }
    }
}