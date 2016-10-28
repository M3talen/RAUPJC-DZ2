using System;
using System.Linq;

namespace Zad3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var integers = new[] {1, 2, 2, 2, 3, 3, 4, 5};
            var data = integers.GroupBy(x => x).Distinct().ToArray();
            var strings = new string[integers.Length];
            foreach (var n in data)
            {
                strings[n.Key] = $"Broj {n.Key} ponavlja se {n.Count()} puta";
                Console.Out.WriteLine(strings[n.Key]);
            }
            Console.In.Read();
        }
    }
}