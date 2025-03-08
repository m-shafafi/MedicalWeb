using MediatR;

namespace Medicals.Application.Commands.Medicals.CreateMedical;

public record CreateMedicalCommand(string Title, string Description, string Category) : IRequest<int>;