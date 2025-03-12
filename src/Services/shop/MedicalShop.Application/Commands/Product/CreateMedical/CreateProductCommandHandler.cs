using MapsterMapper;
using MediatR;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Domain.UnitOfWork.Product;
using MedicalShop.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Medicals.Application.Commands.Medicals.CreateMedical;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductsDto>
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

    public async Task<ProductsDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var newProduct = _mapper.Map<ProductEntity>(request);
        var addedProduct = await _writeUnitOfWork.ProductWriteRepository.AddProductAsync(newProduct);
        _logger.LogInformation($"Product {addedProduct.Id} is successfully created.");


        var addProductEvent = new AddProductEvent
        {
            ProductId = addedProduct.Id,
            ProductTitle = addedProduct.Title
        };
        await _publishEndPoint.Publish(addProductEvent);
        return _mapper.Map<ProductResDto>(addedProduct);
    }
}