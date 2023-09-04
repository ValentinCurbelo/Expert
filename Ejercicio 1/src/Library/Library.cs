using System;

namespace SRP
{
    public class Library
    {
        public void ShelveBook(Book book, String sector, String shelve)
            {
                book.LibrarySector = sector;
                book.LibraryShelve = shelve;
            }
    }
}