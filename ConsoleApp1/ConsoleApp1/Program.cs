using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book = new book("Murad", "roman", 50, 1998, 2000);

            newspaper newspaper = new newspaper("advertisment", "Scientific article", 20, 1860, 300);


            book.sell();
            newspaper.sell();

            
        }

        
    }
}
