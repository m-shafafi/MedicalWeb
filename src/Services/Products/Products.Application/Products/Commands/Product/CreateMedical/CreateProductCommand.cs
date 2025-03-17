using MediatR;
using Products.Domain.Dtos.Products;

namespace Products.Application.Products.Commands.Product.CreateMedical;


public class CreateProductCommand : ProductReqDto, IRequest<ProductResDto>
{
}