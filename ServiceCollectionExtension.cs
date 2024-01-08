using CustomerApi.Services;

namespace CustomerApi
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
