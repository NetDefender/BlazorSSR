using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Shared.Counter;

namespace BlazorApp.Client.Api;

public sealed class ApiService
{
    private readonly HttpClient _client;

    public ApiService(NavigationManager navigator, HttpClient client)
    {
        client.BaseAddress = new Uri(navigator.BaseUri);
        _client = client;
    }

    public async Task<RandomCounter> Random()
    {
        return await _client.GetFromJsonAsync<RandomCounter>("api/Counter/Random");
    }
}
