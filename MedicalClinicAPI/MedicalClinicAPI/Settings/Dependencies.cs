using MedicalClinicAPI.Repositories;
using MedicalClinicAPI.Services;

namespace MedicalClinicAPI.Settings
{
    public class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<DoctorService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<DoctorRepository>();
        }
    }
}
