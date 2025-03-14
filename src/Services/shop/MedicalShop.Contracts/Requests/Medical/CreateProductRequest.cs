﻿namespace MedicalShop.Contracts.Requests.Medicals;

public record CreateProductRequest(int Id, string Name, string Description, decimal Price, int? BrandID, int? CategoryID, string StockQuantity, string SKU, string ImageURL, string Warranty, int Rating);