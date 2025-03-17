using MediatR;
using Products.Contracts.Dtos.Products;

namespace Products.Application.Products.Commands.Product.CreateMedical;


public class CreateProductCommand : ProductReqDto, IRequest<ProductResDto>
{
}