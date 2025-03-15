using MediatR;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Contracts.Responses;
using MedicalShop.Domain.Base;

namespace MedicalShop.Application.Queries.Medicals.GetMedicalById;

public class GetProductsListQuery : ProductFilterPageReqDto, IRequest<PaginitionResDto<List<ProductResDto>>>
{

}