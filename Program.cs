using Microsoft.EntityFrameworkCore;
using Turcu_Teodora_Lab2.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Turcu_Teodora_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Turcu_Teodora_Lab2Context")
        ?? throw new InvalidOperationException("Connection string 'Turcu_Teodora_Lab2Context' not found.")));

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();