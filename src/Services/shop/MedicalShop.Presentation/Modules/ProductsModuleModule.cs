using MediatR;
using Medicals.Application.Commands.Medicals.CreateMedical;
using Medicals.Application.Commands.Medicals.DeleteMedical;
using Medicals.Presentation.Extensions;
using MedicalShop.Application.Commands.Medicals.UpdateProduct;
using MedicalShop.Application.Queries.Medicals.GetMedicalById;
using MedicalShop.Application.Queries.Product.GetProduct;
using MedicalShop.Contracts.Requests.Common;
using MedicalShop.Contracts.Requests.Medicals;
using Microsoft.AspNetCore.Mvc;

namespace Medicals.Presentation.Modules;

public static class ProductsModuleModule
{
    public static void AddMedicalsEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Medicals", async (IMediator mediator, [FromQuery] int pageSize, [FromQuery] int pageNumber, CancellationToken ct) =>
        {
            var paginatedMedicalDtos = await mediator.Send(new GetProductQuery
                (new PaginationParams { PageSize = pageSize, PageNumber = pageNumber }), ct);
            return Results.Extensions.OkPaginationResult(paginatedMedicalDtos.PageSize, paginatedMedicalDtos.CurrentPage,
                paginatedMedicalDtos.TotalCount, paginatedMedicalDtos.TotalPages, paginatedMedicalDtos.Items);
        }).WithTags("Medicals");

        app.MapGet("/api/Medicals/{id}", async (IMediator mediator, int id, CancellationToken ct) =>
        {
            var Medical = await mediator.Send(new GetProductByIdQuery(id), ct);
            return Results.Ok(Medical);
        }).WithTags("Medicals");

        app.MapPost("/api/Medicals", async (IMediator mediator, CreateProductRequest createProductRequest,
            CancellationToken ct) =>
        {
            var command = new CreateProductCommand(createProductRequest.Id, createProductRequest.Name,
                                                        createProductRequest.Description,
                                                        createProductRequest.Price,
                                                        createProductRequest.BrandID,
                                                        createProductRequest.CategoryID,
                                                        createProductRequest.StockQuantity,
                                                        createProductRequest.SKU,
                                                        createProductRequest.ImageURL,
                                                        createProductRequest.Warranty,
                                                        createProductRequest.Rating);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Medicals");

        app.MapPut("/api/Medicals/{id}", async (IMediator mediator, int id,
            UpdateProductCommand updateProductRequest, CancellationToken ct) =>
        {
            var command = new UpdateProductCommand(updateProductRequest.Id, updateProductRequest.Name,
updateProductRequest.Description,
updateProductRequest.Price,
updateProductRequest.BrandID,
updateProductRequest.CategoryID,
updateProductRequest.StockQuantity,
updateProductRequest.SKU,
updateProductRequest.ImageURL,
updateProductRequest.Warranty,
updateProductRequest.Rating);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Medicals");

        app.MapDelete("/api/Medicals/{id}", async (IMediator mediator, int id, CancellationToken ct) =>
        {
            var command = new DeleteProductCommand(id);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Medicals");
    }
}