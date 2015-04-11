using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace PerformanceExample
{
    public static class Boxing
    {
        public static void Comparison()
        {
            var time = new Stopwatch();
            time.Start();

            ArrayList arrayList = new ArrayList(20000000);
            for (int i = 0; i < 20000000; i++)
                arrayList.Add(i);

            time.Stop();
            Console.WriteLine("ArrayList com 20.000.000 itens:");
            Console.WriteLine("Tempo: {0}", time.Elapsed);
            Console.WriteLine("");

            time.Restart();

            List<int> intList = new List<int>(20000000);
            for (int i = 0; i < 20000000; i++)
                intList.Add(i);

            time.Stop();
            Console.WriteLine("List<int> com 20.000.000 itens:");
            Console.WriteLine("Tempo: {0}", time.Elapsed);
        }
    } 
} 
 





