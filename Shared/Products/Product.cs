﻿namespace Shared.Products;

public sealed class Product
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public decimal Price { get; init; }

    public string Description { get; init; }
}