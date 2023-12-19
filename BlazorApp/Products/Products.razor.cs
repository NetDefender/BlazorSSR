using Shared.Products;

namespace BlazorApp.Products;

public partial class Products
{
    private List<Product> _products;

    protected override async Task OnInitializedAsync()
    {
        // Simulate asynchronous loading to demonstrate streaming rendering
        await Task.Delay(500);

        const string lorem = """
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
            Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
            Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
            """;

        _products = [new Product { Id = Guid.NewGuid(), Name = "Sweeter", Price = 36.75M, Description = lorem },
            new Product { Id = Guid.NewGuid(), Name = "Tablet", Price = 142.05M, Description = lorem },
            new Product { Id = Guid.NewGuid(), Name = "Bicycle", Price = 1183.38M, Description = lorem }];
    }
}