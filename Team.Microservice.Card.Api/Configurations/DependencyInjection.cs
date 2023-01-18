using Microsoft.EntityFrameworkCore;
using Team.Microservice.Card.Domain.Interfaces;
using Team.Microservice.Card.Domain.Mappings;
using Team.Microservice.Card.Domain.Services;
using Team.Microservice.Card.Infrastructure.Context;
using Team.Microservice.Card.Infrastructure.Interfaces;
using Team.Microservice.Card.Infrastructure.Repositories;

namespace Team.Microservice.Card.Api.Configurations
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ICardService, CardService>();

            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));
        }
    }
}
