using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Oqtane.Services;
using OqTenants.Services;

namespace OqTenants.Startup
{
    public class ClientStartup : IClientStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            if (!services.Any(s => s.ServiceType == typeof(IMyModuleService)))
            {
                services.AddScoped<IMyModuleService, MyModuleService>();
            }
        }
    }
}
