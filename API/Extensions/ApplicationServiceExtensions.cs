

using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    static public class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration config)
        {


            services.AddDbContext<DataContext>(opt =>
              {
                  opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
              });
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();
            return services;

        }

    }

}