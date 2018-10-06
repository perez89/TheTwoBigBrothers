using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheTwoBigBrothers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTwoBigBrothers.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void getSizeValidNumbersTest()
        {
            int[] arr = { 8, 5, 4, 2, -3 };
            int size = Program.getSizeValidNumbers(arr);
            Assert.AreEqual(5, size);
        }

        [TestMethod()]
        public void getBestBrothersTest()
        {
            int[] arr = { 8, 5, 4, 2, -3, 9, 7, -78, 7 };
            var bigBrothers = Program.getBestBrothers(arr);
            
            Assert.AreEqual(new BigBrothers(-3,-78).getBProduct(), bigBrothers.getBProduct());
        }
    }
}