using UtilsApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var userUrlBase = builder.Configuration.GetSection("ApiUrls:User").Value;
var productUrlBase = builder.Configuration.GetSection("ApiUrls:Product").Value;

builder.Services.AddTransient<UserServices>(s => new UserServices(userUrlBase, new HttpClient()));
builder.Services.AddTransient<ProductServices>(s => new ProductServices(productUrlBase, new HttpClient()));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Authentication}/{id?}");

app.Run();
