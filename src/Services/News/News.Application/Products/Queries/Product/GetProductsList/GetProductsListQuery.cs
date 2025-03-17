using MediatR;
using Products.Contracts.Dtos.Products;
using Products.Domain.Base;
using Products.Domain.Products.Models;

namespace Products.Application.Products.Queries.Product.GetProductsList
{
    public class GetProductsListQuery : ProductFilterPageReqDto, IRequest<PaginitionResDto<List<ProductResDto>>>
    {

    }
}
