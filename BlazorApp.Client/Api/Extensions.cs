using Microsoft.Extensions.Hosting;

namespace BlazorApp.Client.Api;

public static class Extensions
{
    public static void AddClientServices(this IServiceCollection services)
    {
        services.AddHttpClient<ApiService>();
        services.AddScoped<ApiService>();
    }
}