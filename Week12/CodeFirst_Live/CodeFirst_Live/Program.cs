using CodeFirst_Live.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//3.b�l�m kal�p
var connectionString = builder.Configuration.GetConnectionString("defaultConnection");
builder.Services.AddDbContext<PatikaGaleriContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
