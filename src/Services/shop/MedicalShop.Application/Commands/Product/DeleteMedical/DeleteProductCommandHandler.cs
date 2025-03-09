using MediatR;
using MedicalShop.Contracts.Exceptions;
using MedicalShop.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Medicals.Application.Commands.Medicals.DeleteMedical;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
{
    private readonly ApplicationDbContext _ApplicationDbContext;

    public DeleteProductCommandHandler(ApplicationDbContext applicationDbContext)
    {
        _ApplicationDbContext = applicationDbContext;
    }

    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var MedicalToDelete =
            await _ApplicationDbContext.products
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (MedicalToDelete is null)
        {
            throw new NotFoundException($"{nameof(ProductEntity)} with {nameof(ProductEntity.Id)}: {request.Id}" +
                                        $"was not found in database");
        }

        _ApplicationDbContext.products.Remove(MedicalToDelete);
        await _ApplicationDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}