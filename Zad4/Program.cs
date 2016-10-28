using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Example1(); //True
            Example2(); //1

            Console.In.Read();
        }

        private static void Example1()
        {
            var list = new List<Student> {new Student("Ivan", "001234567")};
            var ivan = new Student("Ivan", "001234567");

            var anyIvanExists = list.Any(s => (bool) (s == ivan));
            Console.Out.WriteLine(anyIvanExists);
        }

        private static void Example2()
        {
            var list = new List<Student>
            {
                new Student("Ivan", "001234567"),
                new Student("Ivan", "001234567"),
                new Student("Ivan", "0012345637")
            };
            var distinctStudents = list.Distinct().Count();
            Console.Out.WriteLine(distinctStudents);
        }
    }
}