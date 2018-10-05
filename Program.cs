using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTwoBigBrothers
{
    public class Program
    {
        static int max = 6;

        static void Main(string[] args)
        {
            int[] list = loadArray();

            int sizeValidNumbers = getSizeValidNumbers(list);

            BigBrothers bestBrothers = getBestBrothers(list, sizeValidNumbers);

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

            //Console.ReadLine();
            //for (int i = 0; i < max; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            Console.ReadLine();
        }

        //Calculate the size of the array where only number bigger than 0 area allowed
        public static int getSizeValidNumbers(int[] list)
        {
            int i = 0;

            if (list != null)
            {
                do
                {
                    if (list[i] < 1)
                        break;
                    i++;
                } while (i < max);
            }

            return i;
        }

        //the formula that  given an array of integers finds the maximum product between two numbers of the array and are divisible by 3
        public static BigBrothers getBestBrothers(int[] list, int size)
        {

            BigBrothers bigBrothers = null;
            if (list != null && size > 2)
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

        //carregar o array da consola
        public static int[] loadArray()
        {
            int[] list = new int[max];
            Console.WriteLine("Only numbers are allowed! Write 0 to finalize de input.");

            for (int i = 0; i < max; i++)
            {
                Console.Write("Number:");
                int val;
                bool isNumber = false;
                string c;

                do
                {
                    c = (string)Console.ReadLine();

                    isNumber = Int32.TryParse(c, out val);

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
            if (B1 == 0 || B2 == 0)
                throw new Exception("Values cannot be zero!");

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