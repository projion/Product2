using Microsoft.EntityFrameworkCore;
using Product2.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IRepoProductInfo, RepoProductInfo>();
builder.Services.AddTransient<IRepoStatusInfo_RepoStatusInfo, RepoStatusInfo>();
builder.Services.AddTransient<IRepoUnitInfo_RepoUnitInfo, RepoUnitInfo>();
builder.Services.AddTransient<IRepoSupplierInfo_RepoSupplierInfo, RepoSupplierInfo>();
builder.Services.AddTransient<IRepoStockDetails_RepoStockDetails, RepoStockDetails>();
//builder.Services.AddTransient<IRepoStockMaster_RepoStockMaster, RepoStockMaster>();
//IConfiguration configuration = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .Build();
//builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("DBConnection")));
builder.Services.AddDbContext<AppDbContext>(options =>
        {options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));});
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
