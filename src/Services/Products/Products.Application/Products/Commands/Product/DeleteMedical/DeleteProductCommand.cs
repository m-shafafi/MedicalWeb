using MediatR;

namespace Products.Application.Products.Commands.Product.DeleteMedical;

public class DeleteProductCommand : IRequest<bool>
{
    public int Id { get; set; }
}