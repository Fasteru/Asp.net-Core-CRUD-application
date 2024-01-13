using Microsoft.EntityFrameworkCore;
using SRPS.Entities;
using SRPS.Processor;
using SRPS.Repository;

namespace SRPSMangementWebApp
{
    public static class ConfigureServicesExtension
    {
        /// <summary>
        /// This method is used to add services seprately.
        /// </summary>
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IStudentsInterface, StudentsProcessor>();
            services.AddScoped<GetDataRepository>();
            services.AddScoped<IGetDataInterface, GetDataRepository>();
            services.AddDbContext<SRPSDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
            });
        }
    }
}
