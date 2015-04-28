using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PerformanceExample
{
    public static class Collections
    {
        public static void OrdenedLists()
        {
            var list = new List<int>(30000);
            for (var i = 0; i < 30000; i++)
                list.Add(i);
            list.Sort();

            var sortedList = new SortedList<int, int>(30000);
            for (var i = 0; i < 30000; i++)
                sortedList.Add(i, i);
        }

        public static void SizeOfList()
        {
            var time = new Stopwatch();
            time.Start();
            var listWithSize = new List<int>(50000000);
            for (var i = 0; i < 50000000; i++)
                listWithSize.Add(i);
            time.Stop();
            Console.WriteLine();
            Console.WriteLine("Tempo com o tamanho: {0}", time.Elapsed);
            Console.WriteLine();
            time.Restart();
            var listWithoutSize = new List<int>();
            for (var i = 0; i < 50000000; i++)
                listWithoutSize.Add(i);
            time.Stop();
            Console.WriteLine("Tempo sem o tamanho: {0}", time.Elapsed);
        }
    }
}








