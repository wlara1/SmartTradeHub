using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartTradeHub.Infrastructure.Persistance;
using SmartTradeHub.Infrastructure.Repositories;
using SmartTradeHubApplication.Client;
using SmartTradeHubApplication.Orders;
using SmartTradeHubApplication.Products;

namespace SmartTradeHub.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SmartTradeHubDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IClientRepository, ClientRepository>();

            services.AddScoped<IClientService, ClientService>();

            return services;
        }
    }
}
