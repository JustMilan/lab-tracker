using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using lab_tracker.Data;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<lab_trackerContext>(options =>
    options.UseInMemoryDatabase("lab_trackerContext"));
    //options.UseSqlServer(builder.Configuration.GetConnectionString("lab_trackerContext") ?? throw new InvalidOperationException("Connection string 'lab_trackerContext' not found."))
    

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

CreateDbIfNotExists(app);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


void CreateDbIfNotExists(WebApplication app)
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        try
        {
            var context = services.GetRequiredService<lab_trackerContext>();
            DbInitializer.Initialize(context);
            //context.Database.EnsureCreated();
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred creating the DB.");
        }
    }
}
