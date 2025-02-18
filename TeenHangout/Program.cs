var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Enable serving static files
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
