using MediatR;
using Microsoft.EntityFrameworkCore;
using Medicals.Contracts.Exceptions;
using Medicals.Domain.Entities;
using Medicals.Infrastructure;

namespace Medicals.Application.Commands.Medicals.UpdateMedical;

public class UpdateMedicalCommandHandler : IRequestHandler<UpdateMedicalCommand, Unit>
{
    private readonly MedicalsDbContext _MedicalsDbContext;

    public UpdateMedicalCommandHandler(MedicalsDbContext MedicalsDbContext)
    {
        _MedicalsDbContext = MedicalsDbContext;
    }
    
    public async Task<Unit> Handle(UpdateMedicalCommand request, CancellationToken cancellationToken)
    {
        var MedicalToUpdate =
            await _MedicalsDbContext.Medicals
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (MedicalToUpdate is null)
        {
            throw new NotFoundException($"{nameof(Medical)} with {nameof(Medical.Id)}: {request.Id}" +
                                        $"was not found in database");
        }

        MedicalToUpdate.Description = request.Description;
        MedicalToUpdate.Title = request.Title;
        MedicalToUpdate.Category = request.Category;

        _MedicalsDbContext.Medicals.Update(MedicalToUpdate);
        await _MedicalsDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}