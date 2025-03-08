using MediatR;
using Medicals.Domain.Entities;
using Medicals.Infrastructure;

namespace Medicals.Application.Commands.Medicals.CreateMedical;

public class CreateMedicalCommandHandler : IRequestHandler<CreateMedicalCommand, int>
{
    private readonly MedicalsDbContext _MedicalsDbContext;

    public CreateMedicalCommandHandler(MedicalsDbContext MedicalsDbContext)
    {
        _MedicalsDbContext = MedicalsDbContext;
    }
    
    public async Task<int> Handle(CreateMedicalCommand request, CancellationToken cancellationToken)
    {
        var Medical = new Medical
        {
            Title = request.Title,
            Category = request.Category,
            Description = request.Description,
            CreateDate = DateTime.Now.ToUniversalTime()
        };

        await _MedicalsDbContext.Medicals.AddAsync(Medical, cancellationToken);
        await _MedicalsDbContext.SaveChangesAsync(cancellationToken);

        return Medical.Id;
    }
}