using Microsoft.EntityFrameworkCore;
using RefreshBlazorMemory.Components;
using RefreshBlazorMemory.Data;
using RefreshBlazorMemory.Repos;
using RefreshBlazorMemory.Repos.IRepo;

namespace RefreshBlazorMemory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents();
            builder.Services.AddDbContext<DataContext>(options => 
            { 
                { 
                    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDBConnection")); 
                } 
            });
            builder.Services.AddScoped<IMusicRepo, MusicRepo>();
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
            app.UseAntiforgery();

            app.MapRazorComponents<App>();

            app.Run();
        }
    }
}
