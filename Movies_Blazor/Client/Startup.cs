using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Movies_Blazor.Client.Helpers;

namespace Movies_Blazor.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<SingletonService>();
            services.AddTransient<TransientService>();
            services.AddTransient<IRepository, RepositoryInMemory>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
