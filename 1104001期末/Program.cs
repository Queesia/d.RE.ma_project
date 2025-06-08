using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _1104001´Á¥½.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<_CharContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("_CharContext") ?? throw new InvalidOperationException("Connection string '_CharContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
