var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.MapGet("/About", () => "Our Companys page!");

app.Run();
