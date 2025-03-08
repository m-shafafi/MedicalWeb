using MediatR;
using Microsoft.EntityFrameworkCore;
using Medicals.Contracts.Exceptions;
using Medicals.Domain.Entities;
using Medicals.Infrastructure;

namespace Medicals.Application.Commands.Medicals.DeleteMedical;

public class DeleteMedicalCommandHandler : IRequestHandler<DeleteMedicalCommand, Unit>
{
    private readonly MedicalsDbContext _MedicalsDbContext;

    public DeleteMedicalCommandHandler(MedicalsDbContext MedicalsDbContext)
    {
        _MedicalsDbContext = MedicalsDbContext;
    }
    
    public async Task<Unit> Handle(DeleteMedicalCommand request, CancellationToken cancellationToken)
    {
        var MedicalToDelete =
            await _MedicalsDbContext.Medicals
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (MedicalToDelete is null)
        {
            throw new NotFoundException($"{nameof(Medical)} with {nameof(Medical.Id)}: {request.Id}" +
                                        $"was not found in database");
        }

        _MedicalsDbContext.Medicals.Remove(MedicalToDelete);
        await _MedicalsDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}