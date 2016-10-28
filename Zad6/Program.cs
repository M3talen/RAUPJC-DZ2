using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Zad6
{
    internal class Program
    {
        private static readonly object Lock = new object();
        private static void Main(string[] args)
        {
            var results = new List<int>();
            Parallel.For(0, 100, i =>
            {
                Thread.Sleep(1);
                lock (Lock)
                {
                    results.Add(i*i);
                }
            });
            Console.WriteLine("Bag length should be 100. Length is {0}", results.Count);

            var iterations = new ConcurrentBag<int>();
            Parallel.For(0, 100, i =>
            {
                Thread.Sleep(1);
                iterations.Add(i);
            });
            Console.WriteLine("ConcurrentBag length should be 100. Length is {0}", iterations.Count);

            Console.Read();
        }

        public static void LongOperation(string taskName)
        {
            Thread.Sleep(1000);
            Console.WriteLine("{0}  Finished. Executing  Thread: {1}", taskName, Thread.CurrentThread.ManagedThreadId);
        }
    }
}