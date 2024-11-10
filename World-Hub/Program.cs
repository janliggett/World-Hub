var builder = WebApplication.CreateBuilder(args);

// Adds services to container
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

// Playing around with areas per: https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/areas?view=aspnetcore-8.0

app.MapAreaControllerRoute(
    name: "Asha",
    areaName: "WorldInfo",
    pattern: "WorldInfo/{controller=Asha}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "Asha",
//    pattern: "{controller=Asha}/{action=Index}/{id?}");



/* Trying to make subdirectories in views work for better organization. Currently a WIP.
* https://stackoverflow.com/questions/65038695/asp-net-core-3-1-mvc-app-search-views-in-subdirectory
* 
*/


app.Run();

