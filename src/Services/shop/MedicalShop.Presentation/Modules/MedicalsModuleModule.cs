using MediatR;
using MedicalShop.Contracts.Requests.Common;
using MedicalShop.Contracts.Requests.Medicals;
using Microsoft.AspNetCore.Mvc;

namespace Medicals.Presentation.Modules;

public static class MedicalsModuleModule
{
    public static void AddMedicalsEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Medicals", async (IMediator mediator, [FromQuery] int pageSize, [FromQuery] int pageNumber, CancellationToken ct) =>
        {
            var paginatedMedicalDtos = await mediator.Send(new GetMedicalQuery
                (new PaginationParams { PageSize = pageSize, PageNumber = pageNumber }), ct);
            return Results.Extensions.OkPaginationResult(paginatedMedicalDtos.PageSize, paginatedMedicalDtos.CurrentPage,
                paginatedMedicalDtos.TotalCount, paginatedMedicalDtos.TotalPages, paginatedMedicalDtos.Items);
        }).WithTags("Medicals");

        app.MapGet("/api/Medicals/{id}", async (IMediator mediator, int id, CancellationToken ct) =>
        {
            var Medical = await mediator.Send(new GetMedicalByIdQuery(id), ct);
            return Results.Ok(Medical);
        }).WithTags("Medicals");

        app.MapPost("/api/Medicals", async (IMediator mediator, CreateMedicalRequest createMedicalRequest,
            CancellationToken ct) =>
        {
            var command = new CreateMedicalCommand(createMedicalRequest.Title, createMedicalRequest.Description,
                createMedicalRequest.Category);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Medicals");

        app.MapPut("/api/Medicals/{id}", async (IMediator mediator, int id,
            UpdateMedicalRequest updateMedicalRequest, CancellationToken ct) =>
        {
            var command = new UpdateMedicalCommand(id, updateMedicalRequest.Title, updateMedicalRequest.Description,
                updateMedicalRequest.Category);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Medicals");

        app.MapDelete("/api/Medicals/{id}", async (IMediator mediator, int id, CancellationToken ct) =>
        {
            var command = new DeleteMedicalCommand(id);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Medicals");
    }
}