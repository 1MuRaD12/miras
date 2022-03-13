using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class newspaper:product
    {
        public string Advertisement;
        public string Article;

        public newspaper(string advertisment, string article, int price, int releasedata, int count):base(price,releasedata,count)
        {
            Advertisement = advertisment;
            Article = article;
            
            Console.WriteLine($"advertisment:{advertisment}, article:{article},price:{price}, releasedata:{releasedata}, count:{count}");
            
        }
        
    }
}
