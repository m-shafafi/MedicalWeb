using Mapster;
using MediatR;
using MedicalShop.Application.Queries.Medicals.GetMedicalById;
using MedicalShop.Contracts.Exceptions;
using MedicalShop.Contracts.Responses;
using MedicalShop.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Medicals.Application.Queries.Medicals.GetMedicalById;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdResponse>
{
    private readonly ApplicationDbContext _ApplicationDbContext;

    public GetProductByIdQueryHandler(ApplicationDbContext ApplicationDbContext)
    {
        _ApplicationDbContext = ApplicationDbContext;
    }

    public async Task<GetProductByIdResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var Medical = await _ApplicationDbContext.products
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (Medical is null)
        {
            throw new NotFoundException($"{nameof(Medical)} with {nameof(Medical.Id)}: {request.Id}" +
                                        $"was not found in database");
        }

        return Medical.Adapt<GetProductByIdResponse>();
    }
}