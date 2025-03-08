using FluentValidation;
using Medicals.Domain.Entities;

namespace Medicals.Application.Commands.Medicals.DeleteMedical;

public class DeleteMedicalCommandValidator : AbstractValidator<DeleteMedicalCommand>
{
    public DeleteMedicalCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty()
            .WithMessage($"{nameof(Medical.Id)} cannot be empty");
    }
}