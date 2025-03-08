using MediatR;

namespace Medicals.Application.Commands.Medicals.UpdateMedical;

public record UpdateMedicalCommand(int Id, string Title, string Description, string Category) : IRequest<Unit>;