using FluentValidation;

namespace Medicals.Application.Commands.Medicals.DeleteMedical;

public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty()
            .WithMessage($"{nameof(ProductEntity.Id)} cannot be empty");
    }
}