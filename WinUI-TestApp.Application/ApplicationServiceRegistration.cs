
using Microsoft.Extensions.DependencyInjection;

namespace WinUI_TestApp.Application
{
    public static class ApplicationServiceRegistration
    {
      public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
