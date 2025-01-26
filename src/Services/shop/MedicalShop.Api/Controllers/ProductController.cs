using MedicalShop.Domain.UnitOfWork.Product;
using Microsoft.AspNetCore.Mvc;

namespace MedicalShop.Api.Controllers
{
    public class ProductController : Controller
    {
        private readonly IReadUnitOfWork _readUnitOfWork;
        public ProductController(IReadUnitOfWork readUnitOfWork)
        {
            _readUnitOfWork = readUnitOfWork;
        }
        public IActionResult GetAction()
        {
            return View();
        }
    }
}
