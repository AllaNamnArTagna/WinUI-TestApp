
using Microsoft.Extensions.DependencyInjection;

namespace WinUI_TestApp.Application
{
    public static class InfrastructureServiceRegistration
    {
      public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
