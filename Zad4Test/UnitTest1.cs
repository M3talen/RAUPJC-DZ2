using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad4;

namespace Zad4Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UserExiststTest()
        {
            var list = new List<Student>
            {
                new Student("Ivan", "001234567")
            };
            var ivan = new Student("Ivan", "001234567");
            Assert.IsTrue(list.Any(s => (bool) (s == ivan)));
        }

        [TestMethod]
        public void DistinctUserCount()
        {
            var list = new List<Student>
            {
                new Student("Ivan", "001234567"),
                new Student("Marko", "001234568"),
                new Student("Jure", "001234569")
            };
            Assert.AreEqual(3, list.Distinct().Count());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowNullError()
        {
            var list = new List<Student>();
            var student = list.First(i => true);
        }
    }
}