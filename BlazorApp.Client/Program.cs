using BlazorApp.Client.Api;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddClientServices();
builder.Services.AddFluentUIComponents();
WebAssemblyHost app = builder.Build();
await app.RunAsync();