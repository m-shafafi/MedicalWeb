using MediatR;
using MedicalShop.Contracts.Responses;

namespace MedicalShop.Application.Queries.Medicals.GetMedicalById;

public record GetProductByIdQuery(int Id) : IRequest<GetProductByIdResponse>;