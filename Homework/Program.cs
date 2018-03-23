using System;

namespace Homework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BookStore book = new BookStore(100, true);
            BookStore magazine = new BookStore(50, false, "glossy paper");
            BookStore newspaper = new BookStore(30, "newsprint");
        }
    }
}
