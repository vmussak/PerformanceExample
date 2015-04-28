using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PerformanceExample
{
    public static class Memory
    {
        public static void SizeOf<T>(IList<T> list)
        {
            using (Stream s = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(s, list);
                Console.WriteLine(s.Length / 1024 / 1024);
            }
        }
    }
}
