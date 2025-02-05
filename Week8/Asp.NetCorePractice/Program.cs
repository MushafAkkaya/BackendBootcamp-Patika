var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();// Mvc servisleri i�in

var app = builder.Build();

app.UseStaticFiles(); // wwwroot i�erisindeki statik dosyalar� kullanabilmek i�in

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();

//Controller: Gelen istekleri kar��layan yap�d�r. Gereklili�e g�re Model'a gider.

//Action: Controllera gelen istekleri kar��layan metodlard�r. Controller i�erisinde tan�mlanacak metodlar action olmal�d�r.

//Model: Genellikle veritaban� i�lemleri burada yap�l�r. Veri i�lemleri model i�erisinde yap�l�r.

//View: Uygulaman�n kullan�c�ya g�r�nen y�z�d�r. Frontend tasar�mlar� bu katmandaki .cshtml dosyalar� yoluyla yap�l�r.

//Razor: C# kodlar�n� Html i�erisinde kullanmam�z� sa�lar, .cshtml dosyalar� i�erisinde kullan�l�r.

//RazorView: Razor ve html kodlar�n� birle�tiren MVC View sayfalar�d�r. Yine .cshtml uzant�l� dosyalard�r.

//wwwroot: ��erisinde css, javascript ve resimler vb. dosyalar yer al�r. Bunlar� kullanabilmek i�in yukar�daki tan�mlama yap�l�r.

//builder.Build(): Uygulama nesnesini olu�turur ve bu sayede uygulaman�n servisleri eklenebilir.

//app.Run(): Uygulamay� ba�lat�r ve HTTP isteklerini dinler. Middleware yap�s�n�n son bile�enidir. Yaln�zca bir tane olabilir.