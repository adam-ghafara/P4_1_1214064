using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214064
{
    internal class product_test_1214064
    {
        static void Main(string[] args)
        {
            /*product_1214064 myProduct = new product_1214064();

            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            book_1214064 myBook = new book_1214064("Book", "C# Objek Orientasi Solution", "300");
            dvd_1214064 myDVD = new dvd_1214064("She's Hulk", "120");
            Console.WriteLine(" Product 1 is a {0} called \"{1}\" and has {2} pages", myBook.MyType, myBook.MyTitle, myBook.PageCount);
            Console.WriteLine(" Product 2 is a {0} called \"{1}\" and has {2} minutes duration", myDVD.MyType, myDVD.MyTitle, myDVD.Duration);
            //Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);

        }
    }
}
