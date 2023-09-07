

using ApplicationCore.Interfaces;
using Infrastructure.Data;
using HabanMVC.Services.Job;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HabanMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //DI µù¥U
            // Add services to the container.
            builder.Services.AddControllersWithViews();



            builder.Services.AddDbContext<HaBanContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HaBanContext")));

            builder.Services.AddScoped<HaBanRepository>();
            //builder.Services.AddScoped<HaBanService>();
            builder.Services.AddScoped<IHaBanService, HaBanService>();

            builder.Services.AddScoped<ICandidateIndexVMService, FakeCandidateIndexVMService>();
            builder.Services.AddScoped<FakeFavoriteJobVMService>();

            builder.Services.AddDbContext<FakeHaBanContext>();
            builder.Services.AddScoped<CompanyRepository>();


            builder.Services.AddScoped<CandidateRepository>();
            builder.Services.AddScoped<CandidateService>();
            //builder.Services.AddScoped<CompanyService>();
            builder.Services.AddScoped<ICompanyService, CompanyService>();



            builder.Services.AddScoped<JobRepository>();
            builder.Services.AddScoped<CommonGetServices>();
            builder.Services.AddScoped<JobIndexViewModelService>();
            builder.Services.AddScoped<JobDescriptionViewModelService>();
            builder.Services.AddScoped<AccountEditService>();

            builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));


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
        }
    }
}