using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDB books = new BookDB();
            books.AddBook("Book1", "Vikas", 500, true);
            books.AddBook("Book2", "Vik", 450, true);
            books.AddBook("Book3", "Nik", 350, true);
            ProcessBookdel d = new ProcessBookdel(SellBook);
            d += RentBook;
            books.ProcessPaperbackBooks(d);
            

        }
        static void SellBook(Book book) {
            Console.WriteLine($"Sold Book Title: {book.Title} Price: {book.Price}");
        }
        static void RentBook(Book book)
        {
            Console.WriteLine($"Rent Book Title: {book.Title} Price: {book.Price}");
        }
    }
}
