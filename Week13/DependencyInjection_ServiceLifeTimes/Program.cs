using DependencyInjection_ServiceLifeTimes.Manager;
using DependencyInjection_ServiceLifeTimes.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Servisin yaþam döngüsü tarzýný belirlediðimiz kýsým.
//builder.Services.AddSingleton<ISiramatik, Siramatik>(); // Ýlk istekte bir tane sýramatik nesnesi oluþturulur. Sonraki her istekte o kullanýlýr.
builder.Services.AddScoped<ISiramatik, Siramatik>(); // her *http* isteðinde yeni bir sýramatik nesnesi oluþturulur.
//builder.Services.AddTransient<ISiramatik, Siramatik>(); // her istekte yeni bir sýramatik nesnesi oluþturur.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
