using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.Product.CreateMedical;
using Products.Application.Products.Commands.Product.DeleteMedical;
using Products.Application.Products.Commands.Product.UpdateProduct;
using Products.Domain.Dtos.Products;

namespace Products.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public async Task<ProductResDto> Post(CreateProductCommand request)
        {
            return await _mediator.Send(request);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, UpdateProductCommand request)
        {
            if (id != request.Id)
            {

                return BadRequest("Id in body and query must be equal");
            }
            var res = await _mediator.Send(request);
            return res;

        }
        // DELETE api/<ProductsController>/5
        [HttpDelete]
        public async Task<bool> Delete(DeleteProductCommand request)
        {
            var res = await _mediator.Send(request);
            return res;
        }

    }
}
