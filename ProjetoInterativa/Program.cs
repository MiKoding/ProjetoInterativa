using Microsoft.EntityFrameworkCore;
using ProjetoInterativa.Context;
using ProjetoInterativa.Repositories;
using ProjetoInterativa.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IFabricanteRepository, FabricanteRepository>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();

builder.Services.AddMemoryCache();// adicionado para implementar o cache de memoria
builder.Services.AddSession();
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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Produto}/{action=Index}/{id?}");

app.Run();
