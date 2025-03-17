using MediatR;
using Products.Domain.Base;
using Products.Domain.Dtos.Products;

namespace Products.Application.Products.Queries.Product.GetProductsList
{
    public class GetProductsListQuery : ProductFilterPageReqDto, IRequest<PaginitionResDto<List<ProductResDto>>>
    {

    }
}
