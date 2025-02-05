using MedicalShop.Domain.UnitOfWork.Product;
using Microsoft.AspNetCore.Mvc;

namespace MedicalShop.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    private readonly IReadUnitOfWork _readUnitOfWork;
    public ProductController(IReadUnitOfWork readUnitOfWork)
    {
        _readUnitOfWork = readUnitOfWork;
    }

    [HttpGet("getAction")]
    public IActionResult GetAction()
    {
        return Ok(true);
    }
}
