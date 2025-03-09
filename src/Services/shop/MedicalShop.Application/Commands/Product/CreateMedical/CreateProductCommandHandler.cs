using MediatR;
using MedicalShop.Infrastructure;

namespace Medicals.Application.Commands.Medicals.CreateMedical;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly ApplicationDbContext _ApplicationDbContext;

    public CreateProductCommandHandler(ApplicationDbContext applicationDbContext)
    {
        _ApplicationDbContext = applicationDbContext;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new ProductEntity
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            BrandID = request.BrandID,
            CategoryID = request.CategoryID,
            StockQuantity = request.StockQuantity,
            SKU = request.SKU,
            ImageURL = request.ImageURL,
            Warranty = request.Warranty,
            Rating = request.Rating
        };

        await _ApplicationDbContext.products.AddAsync(product, cancellationToken);
        await _ApplicationDbContext.SaveChangesAsync(cancellationToken);

        return product.Id;
    }
}