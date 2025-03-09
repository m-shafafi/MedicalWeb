using FluentValidation;
using MedicalShop.Application.Commands.Medicals.UpdateProduct;

namespace Medicals.Application.Commands.Medicals.UpdateMedical;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage($"{nameof(ProductEntity.Id)} cannot be empty");

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage($"{nameof(ProductEntity.Name)} cannot be empty")
            .MaximumLength(30)
            .WithMessage($"{nameof(ProductEntity.Name)} cannot be longer than 30 characters");

        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage($"{nameof(ProductEntity.Description)} cannot be empty")
            .MaximumLength(1000)
            .WithMessage($"{nameof(ProductEntity.Description)} cannot be longer than 1000 characters");

        RuleFor(x => x.Price).LessThanOrEqualTo(99999.99m);
        RuleFor(x => x.BrandID)
     .InclusiveBetween(0, 999999);
        RuleFor(x => x.CategoryID)
     .InclusiveBetween(0, 999999);
        RuleFor(x => x.StockQuantity)
         .NotEmpty()
         .WithMessage($"{nameof(ProductEntity.StockQuantity)} cannot be empty")
         .MaximumLength(1000)
         .WithMessage($"{nameof(ProductEntity.StockQuantity)} cannot be longer than 1000 characters");
        RuleFor(x => x.SKU)
         .NotEmpty()
         .WithMessage($"{nameof(ProductEntity.SKU)} cannot be empty")
         .MaximumLength(1000)
         .WithMessage($"{nameof(ProductEntity.SKU)} cannot be longer than 1000 characters");
        RuleFor(x => x.ImageURL)
         .NotEmpty()
         .WithMessage($"{nameof(ProductEntity.ImageURL)} cannot be empty")
         .MaximumLength(1000)
         .WithMessage($"{nameof(ProductEntity.ImageURL)} cannot be longer than 1000 characters");
        RuleFor(x => x.Warranty)
         .NotEmpty()
         .WithMessage($"{nameof(ProductEntity.Warranty)} cannot be empty")
         .MaximumLength(1000)
         .WithMessage($"{nameof(ProductEntity.Warranty)} cannot be longer than 1000 characters");
        RuleFor(x => x.Rating)
    .InclusiveBetween(0, 999999);


    }
}