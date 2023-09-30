var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



//    name: "Account",
//    pattern: "Account/{action=Index}/{id?}"); // Updated pattern for the "Account" controller.

// app.MapControllerRoute(
//    name: "Genres",
//    pattern: "{area:exists}/{controller=News}/{action=AddGenres}");

// app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

// app.Run();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    defaults: new { controller = "Home" });

app.MapControllerRoute(
    name: "Account",
    pattern: "Account/{action=Index}/{id?}",
    defaults: new { controller = "Account" });

app.MapControllerRoute(
    name: "Genre",
    pattern: "Genre/{action=Index}/{id?}",
    defaults: new { controller = "Genre" });

app.Run();