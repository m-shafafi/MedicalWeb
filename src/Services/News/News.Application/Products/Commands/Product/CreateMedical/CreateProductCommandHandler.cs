using EventBus.Messages.Events;
using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;
using Products.Contracts.Dtos.Products;
using Products.Domain.UnitOfWork.Product;
using AutoMapper;

namespace Products.Application.Products.Commands.Product.CreateMedical;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductResDto>
{
    private readonly IWriteUnitOfWork _writeUnitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<CreateProductCommandHandler> _logger;
    private readonly IPublishEndpoint _publishEndPoint;


    public CreateProductCommandHandler(IWriteUnitOfWork writeUnitOfWork, IMapper mapper, IPublishEndpoint publishEndpoint, ILogger<CreateProductCommandHandler> logger)
    {
        _writeUnitOfWork = writeUnitOfWork;
        _mapper = mapper;
        _logger = logger;
        _publishEndPoint = publishEndpoint;
    }

    public async Task<ProductResDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var newProduct = _mapper.Map<ProductEntity>(request);
        var addedProduct = await _writeUnitOfWork.ProductWriteRepository.AddProductAsync(newProduct);
        _logger.LogInformation($"Product {addedProduct.Id} is successfully created.");


        var addProductEvent = new AddProductEvent
        {
            Description = addedProduct.Description,
            Price = addedProduct.Price,
            BrandID = addedProduct.BrandID,
            CategoryID = addedProduct.CategoryID,
            StockQuantity = addedProduct.StockQuantity,
            SKU = addedProduct.SKU,
            ImageURL = addedProduct.ImageURL,
            Warranty = addedProduct.Warranty,
            Rating = addedProduct.Rating,
        };
        await _publishEndPoint.Publish(addProductEvent);
        return _mapper.Map<ProductResDto>(addedProduct);
    }
}