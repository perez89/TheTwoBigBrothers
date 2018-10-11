using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTwoBigBrothers
{
    public static class Utils
    {
        public static int getProduct(int a, int b) {
            return a * b;
        }

        public static bool isDivisibleBy3(this int val)
        {
            return (val % 3) == 0;
        }

        public static bool isSafe(this int[] arr)
        {
            bool result = false;
            if (arr != null && arr.Length > 1) {
                result = true;
            }              

            return result;
        }


        //Calculate the size of the array where only number different than 0 are allowed
        public static int getSizeValidNumbers(this int[] arr)
        {
            var size = arr.Where(m => m != 0).Count();
            return size;
        }
    }
}
