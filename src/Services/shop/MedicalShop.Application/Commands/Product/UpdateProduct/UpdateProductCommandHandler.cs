using MediatR;
using MedicalShop.Contracts.Exceptions;
using MedicalShop.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace MedicalShop.Application.Commands.Medicals.UpdateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
{
    private readonly ApplicationDbContext _ApplicationDbContext;

    public UpdateProductCommandHandler(ApplicationDbContext applicationDbContext)
    {
        _ApplicationDbContext = applicationDbContext;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var MedicalToUpdate =
            await _ApplicationDbContext.products
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (MedicalToUpdate is null)
        {
            throw new NotFoundException($"{nameof(ProductEntity)} with {nameof(ProductEntity.Id)}: {request.Id}" +
                                        $"was not found in database");
        }

        MedicalToUpdate.Name = request.Name;
        MedicalToUpdate.Description = request.Description;
        MedicalToUpdate.Price = request.Price;
        MedicalToUpdate.BrandID = request.BrandID;
        MedicalToUpdate.CategoryID = request.CategoryID;
        MedicalToUpdate.StockQuantity = request.StockQuantity;
        MedicalToUpdate.SKU = request.SKU;
        MedicalToUpdate.ImageURL = request.ImageURL;
        MedicalToUpdate.Warranty = request.Warranty;
        MedicalToUpdate.Rating = request.Rating;

        _ApplicationDbContext.products.Update(MedicalToUpdate);
        await _ApplicationDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}