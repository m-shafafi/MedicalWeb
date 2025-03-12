using MapsterMapper;
using MediatR;
using MedicalShop.Contracts.Exceptions;
using MedicalShop.Domain.UnitOfWork.Product;
using Microsoft.Extensions.Logging;

namespace MedicalShop.Application.Commands.Medicals.UpdateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
{
    private readonly IWriteUnitOfWork _writeUnitOfWork;
    private readonly IReadUnitOfWork _readUnitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<UpdateProductCommandHandler> _logger;

    public UpdateProductCommandHandler(IWriteUnitOfWork writeUnitOfWork, IReadUnitOfWork readUnitOfWork, IMapper mapper, ILogger<UpdateProductCommandHandler> logger)
    {
        _writeUnitOfWork = writeUnitOfWork;
        _readUnitOfWork = readUnitOfWork;
        _mapper = mapper;
        _logger = logger;
    }
    public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _readUnitOfWork.ProductReadRepository.FetchProductEntityAsync(request.Id);
        if (product == null)
        {
            throw new NotFoundException(nameof(ProductEntity), request.Id);
        }
        var updatedProduct = _mapper.Map<ProductEntity>(request);
        await _writeUnitOfWork.ProductWriteRepository.UpdateProductAsync(updatedProduct);
        _logger.LogInformation($"Product {product.Id} is successfully updated.");
        return true;
    }
}