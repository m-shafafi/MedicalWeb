using FluentValidation;
using Medicals.Domain.Entities;

namespace Medicals.Application.Commands.Medicals.CreateMedical;

public class CreateMedicalCommandValidator : AbstractValidator<CreateMedicalCommand>
{
    public CreateMedicalCommandValidator()
    {
        RuleFor(x => x.Category)
            .NotEmpty()
            .WithMessage($"{nameof(Medical.Category)} cannot be empty")
            .MaximumLength(30)
            .WithMessage($"{nameof(Medical.Category)} cannot be longer than 30 characters");
        
        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage($"{nameof(Medical.Description)} cannot be empty")
            .MaximumLength(1000)
            .WithMessage($"{nameof(Medical.Description)} cannot be longer than 1000 characters");
        
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage($"{nameof(Medical.Title)} cannot be empty")
            .MaximumLength(100)
            .WithMessage($"{nameof(Medical.Title)} cannot be longer than 100 characters");
    }
}