using MediatR;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Domain.Base;
using MedicalShop.Domain.Products.Models;

namespace Products.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery : ProductFilterPage, IRequest<PaginitionResDto<List<ProductResDto>>>
    {

    }
}
