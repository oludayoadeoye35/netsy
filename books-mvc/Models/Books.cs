namespace books_mvc.Models;
public class Books
{
    // public int Id { get; set; }
    // public string Title { get; set; }
    // public string Author { get; set; }
    // public string Genre { get; set; }
    // public int YearPublished { get; set; }

    public string[] Library  {get;set;}
    
    public string FavoriteBook { get; set; }


    public Books()
    {
        Library = [ "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice" ];
        FavoriteBook = Library[0];
    }
}