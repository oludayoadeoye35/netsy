using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

Book[] library = [    new Book(1, "1984", "George Orwell", 1949),
    new Book(2, "To Kill a Mockingbird", "Harper Lee", 1960),
    new Book(3, "The Great Gatsby", "F. Scott Fitzgerald", 1925)
];

app.MapGet("/api/books", () => library);
app.MapGet("/api/books/authorsearch/{authorName}", (string authorName) => 
{
   return Array.FindAll(library, book => book.Author.Contains(authorName, StringComparison.OrdinalIgnoreCase));
});
app.MapGet("/api/books/{id}", (int id) => 
{
    var book = library.FirstOrDefault(b => b.Id == id);
    return book is not null ? Results.Ok(book) : Results.NotFound();
});
app.Run();

record Book(int Id, string Title, string Author, int YearPublished){};