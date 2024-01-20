using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProcessorInfo.Logic.Classes;
using ProcessorInfo.Logic.Interfaces;
using ProcessorInfo.Models;
using ProcessorInfo.Repository.Data;
using ProcessorInfo.Repository.Interfaces;
using ProcessorInfo.Repository.Repos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.UI.Services;
using ProcessorInfo.Webapp.Data;

namespace ProcessorInfo.Webapp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var connectionString = builder.Configuration.GetConnectionString("AzureConnection");
            builder.Services.AddDbContext<ProcessorInfoDbContext>(options =>
                options.UseSqlServer(connectionString)
                       .UseLazyLoadingProxies()
            );
            builder.Services.AddDefaultIdentity<SiteUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 2;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ProcessorInfoDbContext>();

            builder.Services.AddTransient<IRepository<Processor>, ProcessorRepository>();
            builder.Services.AddTransient<IRepository<Chipset>, ChipsetRepository>();
            builder.Services.AddTransient<IRepository<Brand>, BrandRepository>();

            builder.Services.AddTransient<IProcessorLogic, ProcessorLogic>();
            builder.Services.AddTransient<IChipsetLogic, ChipsetLogic>();
            builder.Services.AddTransient<IBrandLogic, BrandLogic>();

            builder.Services.AddTransient<IEmailSender, EmailSender>();

            builder.Services.AddControllers();
            builder.Services.AddSignalR();
            builder.Services.AddAuthentication()
            .AddFacebook(opt =>
            {
                opt.AppId = builder.Configuration.GetSection("AppSettings")["AppId"];
                opt.AppSecret = builder.Configuration.GetSection("AppSettings")["AppSecret"];
            })
            .AddMicrosoftAccount(opt =>
            {
                opt.ClientId = builder.Configuration.GetSection("AppSettings")["ClientId"];
                opt.ClientSecret = builder.Configuration.GetSection("AppSettings")["ClientSecret"];
                opt.SaveTokens = true;
            });

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();
            app.Run();
        }
    }
}