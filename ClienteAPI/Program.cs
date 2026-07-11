var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/api/clientes", () => Results.Ok(Array.Empty<object>()));
app.MapGet("/api/clientesdocumento", () => Results.Ok(Array.Empty<object>()));
app.Run();
