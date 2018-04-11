using System;
namespace Homework
{
    public class MainClass 
    {
        public static void Main(string[] args)
        {
            int readers = 10;

            Activities april = new Activities();
            april.Increase(readers);
            april.PrintIncrease(readers);

            Library renewal = new Library();
            renewal.AddBooks(books);
            renewal.PrintBooks(books);
        }
    }
}

            //BookStore book = new BookStore(100, true);
            //BookStore magazine = new BookStore(50, false, "glossy paper");
            //BookStore newspaper = new BookStore(30, "newsprint");