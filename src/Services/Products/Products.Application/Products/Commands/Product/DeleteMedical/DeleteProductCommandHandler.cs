using MediatR;
using Microsoft.Extensions.Logging;
using Products.Application.Exception;
using Products.Domain.UnitOfWork.Product;

namespace Products.Application.Products.Commands.Product.DeleteMedical;


public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
{
    private readonly IWriteUnitOfWork _writeUnitOfWork;
    private readonly IReadUnitOfWork _readUnitOfWork;

    private readonly ILogger<DeleteProductCommandHandler> _logger;

    public DeleteProductCommandHandler(IWriteUnitOfWork writeUnitOfWork, IReadUnitOfWork readUnitOfWork, ILogger<DeleteProductCommandHandler> logger)
    {
        _writeUnitOfWork = writeUnitOfWork;
        _readUnitOfWork = readUnitOfWork;
        _logger = logger;
    }
    public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _readUnitOfWork.ProductReadRepository.FetchProductEntityAsync(request.Id);
        if (product == null)
        {
            throw new NotFoundException("Product", request.Id);
        }

        await _writeUnitOfWork.ProductWriteRepository.DeleteProductAsync(product);

        return true;


    }
}

