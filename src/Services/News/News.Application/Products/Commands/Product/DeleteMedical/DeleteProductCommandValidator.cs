using FluentValidation;

namespace Products.Application.Products.Commands.Product.DeleteMedical;

public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty()
            .WithMessage($"{nameof(ProductEntity.Id)} cannot be empty");
    }
}