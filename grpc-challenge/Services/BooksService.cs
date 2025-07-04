using Grpc.Core;
using grpc_challenge;

namespace grpc_challenge.Services;

public class BooksService : Books.BooksBase
{
   record Book(int Id, string Title, string Author, int Rating){};

   private Book[] library = [
        new Book(1, "1984", "George Orwell", 5),
        new Book(2, "To Kill a Mockingbird", "Harper Lee", 4),
        new Book(3, "The Great Gatsby", "F. Scott Fitzgerald", 3),
        new Book(4, "Moby Dick", "Herman Melville", 2)
   ];

    public override Task<BookAuthor> GetAuthor(BookTitle request, ServerCallContext context)
    {
       var book = library.FirstOrDefault(b => b.Title.Equals(request.Title, StringComparison.OrdinalIgnoreCase));
    }


}
