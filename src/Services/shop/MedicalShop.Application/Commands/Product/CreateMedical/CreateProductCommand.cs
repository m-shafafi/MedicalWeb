using MediatR;
using MedicalShop.Contracts.Dtos.Products;

namespace Medicals.Application.Commands.Medicals.CreateMedical;


public class CreateProductCommand : ProductReqDto, IRequest<ProductResDto>
{
}