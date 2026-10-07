using  BookIt.CoreApi.Application.Health;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHealth();

var app = builder.Build();

app.MapControllers();

app.Run();

public partial class Program { }