using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewPallets.Domain.Interfaces;
using ViewPallets.Infrastructure.Persistence;
using ViewPallets.Infrastructure.Repositories;
using ViewPallets.Infrastructure.Seeders;

namespace ViewPallets.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PalletDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("PalletsDb"));
            });

            services.AddScoped<PalletsSeeder>();
            services.AddScoped<IPalletRepository, PalletRepository>();
        }
    }
}
