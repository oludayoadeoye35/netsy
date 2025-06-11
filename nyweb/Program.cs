var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization();


var app = builder.Build();

if ( builder.Environment.IsDevelopment() )
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.Use(async (context, next) =>{
        context.Response.Headers.Append("X-my-great-header", "Hello World");
    await next.Invoke();
});

app.MapGet("/", () => "Hello World!");
app.MapGet("/About", () => "this page disucss our company!");

app.Run();
