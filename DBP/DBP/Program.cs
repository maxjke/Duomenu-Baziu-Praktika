using DAL;
using DAL.Implementations;
using DAL.Interfaces;

namespace DBP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            // BL


            // DAL
            builder.Services.AddScoped<IDbHelper, DbHelper>();
            builder.Services.AddScoped<IAdvertisementDAL, AdvertisementDAL>();
            builder.Services.AddScoped<ICompanyDAL, CompanyDAL>();
            builder.Services.AddScoped<IBillingInformationDAL, BillingInformationDAL>();
            


            builder.Services.AddMvc();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           // app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            DbHelper.ConnString = app.Configuration["ConnectionStrings:Default"] ?? "";

            app.Run();
        }
    }
}