using CustomerApi.Services;

namespace CustomerApi.ServiceContainer
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();

            return services;
        }
    }
}
