
using Mapster;
using MediatR;
using Medicals.Application.Helpers;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Contracts.Responses;
using MedicalShop.Infrastructure;

namespace MedicalShop.Application.Queries.Product.GetProduct;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, PaginatedList<ProductsDto>>
{
    private readonly ApplicationDbContext _ApplicationDbContext;

    public GetProductQueryHandler(ApplicationDbContext MedicalsDbContext)
    {
        _ApplicationDbContext = MedicalsDbContext;
    }

    public async Task<PaginatedList<ProductsDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var GetMediclasQuery = _ApplicationDbContext.products.ProjectToType<ProductsDto>().AsQueryable();

        var paginatedList = await CollectionHelper<ProductsDto>.ToPaginatedList(GetMediclasQuery,
            request.PaginationParams.PageNumber,
            request.PaginationParams.PageSize);

        return paginatedList;
    }
}