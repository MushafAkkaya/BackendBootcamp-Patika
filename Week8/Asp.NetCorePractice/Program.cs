var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();// Mvc servisleri için

var app = builder.Build();

app.UseStaticFiles(); // wwwroot içerisindeki statik dosyalarý kullanabilmek için

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();

//Controller: Gelen istekleri karþýlayan yapýdýr. Gerekliliðe göre Model'a gider.

//Action: Controllera gelen istekleri karþýlayan metodlardýr. Controller içerisinde tanýmlanacak metodlar action olmalýdýr.

//Model: Genellikle veritabaný iþlemleri burada yapýlýr. Veri iþlemleri model içerisinde yapýlýr.

//View: Uygulamanýn kullanýcýya görünen yüzüdür. Frontend tasarýmlarý bu katmandaki .cshtml dosyalarý yoluyla yapýlýr.

//Razor: C# kodlarýný Html içerisinde kullanmamýzý saðlar, .cshtml dosyalarý içerisinde kullanýlýr.

//RazorView: Razor ve html kodlarýný birleþtiren MVC View sayfalarýdýr. Yine .cshtml uzantýlý dosyalardýr.

//wwwroot: Ýçerisinde css, javascript ve resimler vb. dosyalar yer alýr. Bunlarý kullanabilmek için yukarýdaki tanýmlama yapýlýr.

//builder.Build(): Uygulama nesnesini oluþturur ve bu sayede uygulamanýn servisleri eklenebilir.

//app.Run(): Uygulamayý baþlatýr ve HTTP isteklerini dinler. Middleware yapýsýnýn son bileþenidir. Yalnýzca bir tane olabilir.