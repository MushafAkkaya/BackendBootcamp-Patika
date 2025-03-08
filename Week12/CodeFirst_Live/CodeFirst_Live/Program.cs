using CodeFirst_Live.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//3.bölüm kalýp
var connectionString = builder.Configuration.GetConnectionString("defaultConnection");
builder.Services.AddDbContext<PatikaGaleriContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
