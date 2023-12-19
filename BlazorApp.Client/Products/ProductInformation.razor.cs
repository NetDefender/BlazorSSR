using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Shared.Products;

namespace BlazorApp.Client.Products;

public partial class ProductInformation
{
    [Parameter]
    public string Product { get; set; }

    private Product _product;

    [Inject]
    public IToastService ToastService { get; set; }

    protected override void OnParametersSet()
    {
        _product = JsonSerializer.Deserialize<Product>(Product);
    }

    private Task Buy()
    {
        ToastService.ShowSuccess($"{_product.Name} added to cart");
        return Task.CompletedTask;
    }
}