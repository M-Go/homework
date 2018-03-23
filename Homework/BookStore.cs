using System;
namespace Homework
{
    public class BookStore
    {
        int number_of_pages;
        bool rigid_cover;
        string additional_info;

        public BookStore(int pages, bool cover)
        {
            number_of_pages = pages;
            rigid_cover = cover;
            Console.WriteLine($"This is a book with {number_of_pages} pages and rigid cover");
        }

        public BookStore(int pages, bool cover, string additional)
        {
            number_of_pages = pages;
            rigid_cover = cover;
            additional_info = additional;
            Console.WriteLine($"This is a magazine with {number_of_pages} pages and with {additional_info}");
        }

        public BookStore(int pages, string additional)
        {
            number_of_pages = pages;
            additional_info = additional;
            Console.WriteLine($"This is a newspaper with {number_of_pages} pages and with {additional_info} paper");
        }
    }
}
