using System;
namespace Homework
{
    public class Activities
    {
        public void AddBooks(Library books)
        {
            books = books + 1;
        }

        public void Increase(int readers)
        {
            readers = readers + 1;
        }

        public void PrintBooks(Library books)
        {
            Console.WriteLine(books);
        }

        public void PrintIncrease(int readers)
        {
            Console.WriteLine(readers);
        }
    }
}