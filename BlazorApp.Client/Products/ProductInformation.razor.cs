using Shared.Products;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorApp.Client.Products;

public partial class ProductInformation
{
    [Parameter]
    public Product Product { get; set; }

    [Inject]
    public IToastService ToastService { get; set; }

    private Task Buy()
    {
        ToastService.ShowSuccess($"{Product.Name} added to cart");
        return Task.CompletedTask;
    }
}