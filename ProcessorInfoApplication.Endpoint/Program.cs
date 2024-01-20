using ProcessorInfo.Logic.Classes;
using ProcessorInfo.Logic.Interfaces;
using ProcessorInfo.Models;
using ProcessorInfo.Repository.Data;
using ProcessorInfo.Repository.Interfaces;
using ProcessorInfo.Repository.Repos;
using ProcessorInfoApplication.Endpoint.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace ProcessorInfoApplication.Endpoint
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
                options.SignIn.RequireConfirmedAccount = false;
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

            builder.Services.AddControllers();
            builder.Services.AddSignalR();            // Add services to the container.

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(t =>
            {
                t.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "ProcessorInfo.Endpoint",
                    Version = "v1",
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI(t => t.SwaggerEndpoint("/swagger/v1/swagger.json", "ProcessorInfo.Endpoint v1"));
            //}
            //This is not cool but this is just my own project so it's okay
            app.UseSwagger();
            app.UseSwaggerUI(t => t.SwaggerEndpoint("/swagger/v1/swagger.json", "ProcessorInfo.Endpoint v1"));


            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<SignalRHub>("/hub");
            });

            app.MapControllers();

            app.Run();
        }
    }
}