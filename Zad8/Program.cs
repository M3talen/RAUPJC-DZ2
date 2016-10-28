using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad8
{
    class Program
    {
         static void Main(string[] args)
         {
             var t = Task.Run(() => LetsSayUserClickedAButtonOnGuiMethod());
             Console.Read();
         }

         private static void LetsSayUserClickedAButtonOnGuiMethod()
         { 
             var result = GetTheMagicNumber();
             Console.WriteLine(result);
         }

         private static long GetTheMagicNumber()
         {
             return IKnowIGuyWhoKnowsAGuy().Result;
         }

         private static async Task<long> IKnowIGuyWhoKnowsAGuy()
         {
             var t1 = IKnowWhoKnowsThis(10);
             var t2 = IKnowWhoKnowsThis(5);
             await Task.WhenAll(t1, t2);
             return t1.Result + t2.Result;
         } 

         private static async Task<long> IKnowWhoKnowsThis(int n)
         {
             return await Zad7.Program.FactorialDigitSum(n);
         }
        }
}
