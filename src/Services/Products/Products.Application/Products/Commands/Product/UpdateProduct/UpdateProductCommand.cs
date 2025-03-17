using MediatR;
using Products.Domain.Dtos.Products;

namespace Products.Application.Products.Commands.Product.UpdateProduct;

public class UpdateProductCommand : ProductReqDto, IRequest<bool>
{

}