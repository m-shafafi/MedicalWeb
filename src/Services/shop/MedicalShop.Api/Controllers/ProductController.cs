using MedicalShop.Domain.Products.Models;
using MedicalShop.Domain.UnitOfWork.Product;
using Microsoft.AspNetCore.Mvc;

namespace MedicalShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IReadUnitOfWork _readUnitOfWork;
    public ProductController(IReadUnitOfWork readUnitOfWork)
    {
        _readUnitOfWork = readUnitOfWork;
    }

    [HttpGet("getAction")]
    public async Task<List<ProductEntity>>  GetAll()
    {
        return await _readUnitOfWork.ProductReadRepository.FetchAllProductEntityAsync();
    }
}
