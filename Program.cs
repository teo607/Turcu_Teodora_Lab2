using Microsoft.EntityFrameworkCore;
using Turcu_Teodora_Lab2.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<Turcu_Teodora_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Turcu_Teodora_Lab2Context")
        ?? throw new InvalidOperationException("Connection string 'Turcu_Teodora_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Turcu_Teodora_Lab2Context")
        ?? throw new InvalidOperationException("Connection string 'Turcu_Teodora_Lab2Context' not found.")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LibraryIdentityContext>();

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