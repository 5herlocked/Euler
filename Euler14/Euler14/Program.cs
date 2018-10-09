using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler14
{
    internal static class Program
    {
        private static List<List<ulong>> _list = new List<List<ulong>>();

        private static void Main(string[] args)
        {
            var row = 0;
            
            for (ulong i = 100; i < 1000001; i++)
            {
               _list.Add(new List<ulong>());
                GetCollatzSeq(i, row++);
            }

            var maxLength = _list[0];

            foreach (var t in _list)
            {
                if (t.Count > maxLength.Count)
                {
                    maxLength = t;
                }
            }
            
            Console.WriteLine(string.Join(" ", maxLength));
            Console.WriteLine();
            
            Console.ReadLine();
        }

        private static void GetCollatzSeq(ulong current, int row)
        {
            if (current == 1)
            {
                _list[row].Add(1);
                return;
            }
            
            switch (current % 2)
            {
                case 1:
                    _list[row].Add(current);
                    GetCollatzSeq(current*3 + 1, row);
                    break;
                case 0:
                    _list[row].Add(current);
                    GetCollatzSeq(current/2, row);
                    break;
            }
        }
    }
}