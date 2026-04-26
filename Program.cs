var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// IMPORTANTE para Render
app.Urls.Add("http://0.0.0.0:80");

app.MapGet("/", () => "Hola Mundo desde .NET 🚀");

app.Run();
