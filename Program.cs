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

            BigBrothers bestBrothers = getBestBrothers2(list);

            if (bestBrothers == null)
            {
                Console.WriteLine("There were no valid combination!");
            }
            else
            {
                Console.WriteLine("bestBrothers.A = " + bestBrothers.getB1());
                Console.WriteLine("bestBrothers.B = " + bestBrothers.getB2());
                Console.WriteLine("bestBrothers.Multi = " + bestBrothers.getProduct());
            }

            Console.ReadLine();
        }


        //formula that, given an array of integers, find the maximum product between two numbers from the array, that is a multiple of 3
  

        public static BigBrothers getBestBrothers2(int[] list)
        {
            BigBrothers bigBrothers = new BigBrothers(int.MinValue);
            //safe = not null and more than 1 elements
            if (list.isSafe())
            {             
              
                for (int a = 0; a < list.Length; a++)
                {
                    var value = list[a];
                    if ((value > bigBrothers.getB2()) && value.isDivisibleBy3())
                    {
                        if(bigBrothers.getB2()> bigBrothers.getB1())
                            bigBrothers.setB1(bigBrothers.getB2());

                        bigBrothers.setB2(value);
                    }
                    else if ((value > bigBrothers.getB1()) && (bigBrothers.getB2() != value)) {                         
                      bigBrothers.setB1(value);                       
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

        public BigBrothers(int defaultValue)
        {
            this.B1 = defaultValue;
            this.B2 = defaultValue;
        }

        public int getB1()
        {
            return this.B1;
        }

        public int getB2()
        {
            return this.B2;
        }

        public void setB1(int b1)
        {
            this.B1 =b1;
        }

        public void setB2(int b2)
        {
            this.B2 = b2;
        }

        public int getProduct()
        {
            return this.B2 * this.B1;
        }

 
    }
}