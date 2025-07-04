using System.Collections.Generic;
using System.Linq;

namespace Summaries.Data
{
    public class BookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBook(int id, Book newBook)
        {
            var oldBook = Data.Books.FirstOrDefault(n => n.Id == id);
            if(oldBook != null)
            {
                oldBook.Title = newBook.Title;
                oldBook.Author = newBook.Author;
                oldBook.Description = newBook.Description;
                oldBook.Rate = newBook.Rate;
                oldBook.DateStart = newBook.DateStart;
                oldBook.DateRead = newBook.DateRead;
            }
        }
    }
}