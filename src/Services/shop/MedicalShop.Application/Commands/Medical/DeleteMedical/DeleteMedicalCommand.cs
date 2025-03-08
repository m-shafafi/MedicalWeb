using MediatR;

namespace Medicals.Application.Commands.Medicals.DeleteMedical;

public record DeleteMedicalCommand(int Id) : IRequest<Unit>;