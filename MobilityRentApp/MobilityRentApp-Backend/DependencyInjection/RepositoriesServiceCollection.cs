using MobilityRentApp_Backend.Data.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepositoriesServiceCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services.AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IMobilityKindRepository, MobilityKindRepository>()
            .AddScoped<IMobilityRepository, MobilityRepository>()
            .AddScoped<IRentEnrollmentRepository, RentEnrollmentRepository>();
    }
}
