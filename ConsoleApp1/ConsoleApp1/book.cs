using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class book:product
    {
        public string Author;
        public string Genre;

        public book(string author, string genre, int price, int releasedata, int count):base(price,releasedata,count)
        {
            Author = author;
            Genre = genre;
            
            Console.WriteLine($"author:{author}, genre:{genre}, price:{price}, releasedata:{releasedata}, count:{count}");
        }
    }
}
