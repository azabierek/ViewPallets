using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ViewPallets.Application.Mappings;
using ViewPallets.Application.PalletCQRS.Queries.GetPalletInformations;

namespace ViewPallets.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services) 
        {
            services.AddMediatR(typeof(GetPalletInformationsQuery));
            services.AddAutoMapper(typeof(PalletMappingProfile));
        }
    }
}
