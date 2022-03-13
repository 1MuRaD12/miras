using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class product
    {
        public int Price;
        public int ReleaseDate;
        public int Count;

        public product(int price, int releasedata, int count)
        {
            Price = price;
            ReleaseDate = releasedata;
            Count = count;
        }
        public  void sell ()
        {
            
                Count--;
            if (Count == 0)
            {
                Console.WriteLine("the sales process did not take place");
            }
        }

    }
}
