using Microsoft.Extensions.DependencyInjection;
using ViewPallets.Application.Mappings;
using ViewPallets.Application.Services;

namespace ViewPallets.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services) 
        {
            services.AddScoped<IPalletService, PalletService>();

            services.AddAutoMapper(typeof(PalletMappingProfile));
        }
    }
}
