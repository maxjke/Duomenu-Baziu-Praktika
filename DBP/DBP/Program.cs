using BL.Persons;
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
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
            builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();


            // DAL
            builder.Services.AddScoped<IDbHelper, DbHelper>();
            builder.Services.AddScoped<IAdvertisementDAL, AdvertisementDAL>();
            builder.Services.AddScoped<ICompanyDAL, CompanyDAL>();
            builder.Services.AddScoped<IBillingInformationDAL, BillingInformationDAL>();
            builder.Services.AddScoped<IAssingmentDAL, AssingmentDAL>();
            builder.Services.AddScoped<ICareerCenterDAL, CareerCenterDAL>();
            builder.Services.AddScoped<ICertificateDAL, CertificateDAL>();
            builder.Services.AddScoped<ICompanyOfferDAL, CompanyOfferDAL>();
            builder.Services.AddScoped<IConsultationDAL, ConsultationDAL>();
            builder.Services.AddScoped<IContactInfoDAL, ContactInfoDAL>();
            builder.Services.AddScoped<ICourseDAL, CourseDAL>();
            builder.Services.AddScoped<IGradeDAL,GradeDAL>();
            builder.Services.AddScoped<IGroupDAL, GroupDAL>();
            builder.Services.AddScoped<IInformationSourceDAL, InformationSourceDAL>();
            builder.Services.AddScoped<ILectureDAL,LectureDAL>();
            builder.Services.AddScoped<IOrderDAL, OrderDAL>();
            builder.Services.AddScoped<IPaymentMethodDAL,PaymentMethodDAL>();
            builder.Services.AddScoped<IReviewDAL, ReviewDAL>();
            builder.Services.AddScoped<IScheduleDAL, ScheduleDAL>();
            builder.Services.AddScoped<IStudentDAL, StudentDAL>();
            builder.Services.AddScoped<ITeacherDAL, TeacherDAL>();


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