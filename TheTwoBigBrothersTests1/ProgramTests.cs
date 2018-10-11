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
        //[TestMethod()]
        //public void getSizeValidNumbersTest()
        //{
        //    int[] arr = { 8, 5, 4, 2, -3 };
        //    int size = Program.getSizeValidNumbers(arr);
        //    Assert.AreEqual(5, size);
        //}

        [TestMethod()]
        public void getBestBrothersTest()
        {
            int[] arr = {1,2,6,8,3,9,9 };
            //var bigBrothers = Program.getBestBrothers(arr);
            var bigBrothers = Program.getBestBrothers2(arr);

            Assert.AreEqual(9*8, bigBrothers.getProduct());
            
   
        }

        [TestMethod()]
        public void getBestBrothersTest2()
        {
            int[] arr = { 6, 8, 8, 7, 2, 5 };
            //var bigBrothers = Program.getBestBrothers(arr);
            var bigBrothers = Program.getBestBrothers2(arr);

            Assert.AreEqual(6 * 8, bigBrothers.getProduct());


        }

        [TestMethod()]
        public void getBestBrothersTest3()
        {
            int[] arr = { 1, 9, 2, 4 };
            //var bigBrothers = Program.getBestBrothers(arr);
            var bigBrothers = Program.getBestBrothers2(arr);

            Assert.AreEqual(9*4, bigBrothers.getProduct());


        }

        [TestMethod()]
        public void getBestBrothersTest4()
        {
            int[] arr = { 1, 1, 2, 1, 5, 7, 1, 5, 7, 3, 9 };
            //var bigBrothers = Program.getBestBrothers(arr);
            var bigBrothers = Program.getBestBrothers2(arr);

            Assert.AreEqual(9 * 7, bigBrothers.getProduct());


        }

        [TestMethod()]
        public void getBestBrothersTest5()
        {
            int[] arr = { 13, 2, 6, 7, 3, 11, 9 };
            //var bigBrothers = Program.getBestBrothers(arr);
            var bigBrothers = Program.getBestBrothers2(arr);

            Assert.AreEqual(13 * 9, bigBrothers.getProduct());


        }

    }
}