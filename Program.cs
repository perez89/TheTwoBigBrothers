using System;
using System.Linq;

namespace TheTwoBigBrothers
{
    public class Program
    {
        static int maxListSize = 10;

        static void Main(string[] args)
        {
            int[] list = loadArray();            

            BigBrothers bestBrothers = getBestBrothers(list);

            if (bestBrothers == null)
            {
                Console.WriteLine("There were no valid combination!");
            }
            else
            {
                Console.WriteLine("bestBrothers.A = " + bestBrothers.getB1());
                Console.WriteLine("bestBrothers.B = " + bestBrothers.getB2());
                Console.WriteLine("bestBrothers.Multi = " + bestBrothers.getBProduct());
            }

            Console.ReadLine();
        }

        //Calculate the size of the array where only number different than 0 are allowed
        public static int getSizeValidNumbers(int[] list)
        {     
            var size = list.Where(m => m != 0 ).Count();
            return size;
        }

        //formula that, given an array of integers, find the maximum product between two numbers from the array, that is a multiple of 3
        public static BigBrothers getBestBrothers(int[] list)
        {
            int size = getSizeValidNumbers(list);

            BigBrothers bigBrothers = null;
            if (list != null && size > 1)
            {
            
                for (int a = 0; a < size - 1; a++)
                {
                    for (int b = a + 1; b < size; b++)
                    {
                        Console.WriteLine("a=" + list[a] + " | b=" + list[b]);

                        BigBrothers brothers = new BigBrothers(list[a], list[b]);
                        if (brothers.isValid())
                        {
                            if (bigBrothers == null)
                            {
                                bigBrothers = brothers;
                            }
                            else
                            {
                                if (brothers.getBProduct() > bigBrothers.getBProduct())
                                {
                                    bigBrothers = brothers;
                                }
                            }


                        }
                    }
                }
            }

            return bigBrothers;
        }

        //load int array from console
        public static int[] loadArray()
        {
            int[] list = new int[maxListSize];
            Console.WriteLine("Only numbers are allowed! Write 0 to finalize de input.");

            for (int i = 0; i < maxListSize; i++)
            {
               
                int val;
                bool isNumber = false;
                string c;

                do
                {
                    Console.Write("Number:");
                    c = (string)Console.ReadLine();

                    isNumber = Int32.TryParse(c, out val);
                    if(!isNumber)
                        Console.WriteLine("Not valid!");

                } while (!isNumber);


                if (c.Equals("0"))
                    break;

                list[i] = val;
            }
            return list;
        }
    }

    public class BigBrothers
    {
        private int B1;
        private int B2;
        private int BProduct;

        public BigBrothers(int B1, int B2)
        {
            this.B1 = B1;
            this.B2 = B2;
            this.BProduct = B1 * B2;
        }

        public int getB1()
        {
            return this.B1;
        }

        public int getB2()
        {
            return this.B2;
        }

        public int getBProduct()
        {
            return this.BProduct;
        }

        public bool isValid()
        {
            if (this.BProduct % 3 == 0)
                return true;
            else
                return false;
        }
    }
}