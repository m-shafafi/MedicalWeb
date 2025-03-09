using FluentValidation;

namespace MedicalShop.Application.Queries.Medicals.GetMedicalById;

public class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
{
    public GetProductByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty()
            .WithMessage($"{nameof(ProductEntity.Id)} cannot be empty");
    }
}