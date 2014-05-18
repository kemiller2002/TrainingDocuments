using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Katas;

namespace KataUnitTests
{
    [TestClass]
    class SortingTests
    {

        string[] names = "Peter Pan; Ripley; Cook; Starbuck; Rose Tyler".Split(';');

        [TestMethod]
        public void TestSortFoward()
        {
            var target = new Sorting();


            var actual = target.SortString(names);

           Assert.AreEqual(names.Length, actual.Count);
           Assert.AreEqual(names[2], actual.First());

        }

        [TestMethod]
        public void TestSortBackward()
        {
            var target = new Sorting();

            var actual = target.SortStringInReverse(names);

            Assert.AreEqual(names.Length, actual.Count);
            Assert.AreEqual(names[3], actual.First());
        }


    }
}
