using MediatR;

namespace Medicals.Application.Commands.Medicals.DeleteMedical;

public record DeleteProductCommand(int Id) : IRequest<Unit>;