using MediatR;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Domain.Base;

namespace Products.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery : ProductFilterPageReqDto, IRequest<PaginitionResDto<List<ProductDto>>>
    {

    }
}
