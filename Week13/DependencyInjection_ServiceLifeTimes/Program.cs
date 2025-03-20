using DependencyInjection_ServiceLifeTimes.Manager;
using DependencyInjection_ServiceLifeTimes.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Servisin ya�am d�ng�s� tarz�n� belirledi�imiz k�s�m.
//builder.Services.AddSingleton<ISiramatik, Siramatik>(); // �lk istekte bir tane s�ramatik nesnesi olu�turulur. Sonraki her istekte o kullan�l�r.
builder.Services.AddScoped<ISiramatik, Siramatik>(); // her *http* iste�inde yeni bir s�ramatik nesnesi olu�turulur.
//builder.Services.AddTransient<ISiramatik, Siramatik>(); // her istekte yeni bir s�ramatik nesnesi olu�turur.

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
