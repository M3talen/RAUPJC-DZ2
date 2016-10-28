using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Zad7
{
    internal class Program
    {
        //private static long _result;

        private static void Main(string[] args)
        {
            var task = Task.Run(() => MainAsync());
            Task.WaitAll(task);

            Console.Read();
        }

        private static async void MainAsync()
        {
            Console.WriteLine(await FactorialDigitSum(1));
            Console.WriteLine(await FactorialDigitSum(1));
            Console.WriteLine(await FactorialDigitSum(2));
            Console.WriteLine(await FactorialDigitSum(3));
            Console.WriteLine(await FactorialDigitSum(4));
            Console.WriteLine(await FactorialDigitSum(5));
            Console.WriteLine(await FactorialDigitSum(6));
            Console.WriteLine(await FactorialDigitSum(7));
        }

        public static async Task<long> FactorialDigitSum(int num)
        {
            var task = Task.Run(() => GetFactorialDigitSum(num));
            await task;
            return task.Result;
        }

        private static long GetFactorialDigitSum(int num)
        {
            long result = num;
            for (var i = 1; i < num; i++)
                result = result * i;
            return result;
        }
    }
}