using MapsterMapper;
using MediatR;
using MedicalShop.Application.Queries.Medicals.GetMedicalById;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Contracts.Responses;
using MedicalShop.Domain.Base;
using MedicalShop.Domain.Products.Models;
using MedicalShop.Domain.UnitOfWork.Product;
using Products.Application.Products.Queries.GetProductsList;

namespace Medicals.Application.Queries.Medicals.GetMedicalById;

    internal class GetProductsListQueryHandler : IRequestHandler<GetProductByIdQuery, PaginitionResDto<List<ProductResDto>>>
    {

        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IReadUnitOfWork readUnitOfWork, IMapper mapper)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
        }
        public async Task<PaginitionResDto<List<ProductResDto>>> Handle(ProductFilterPage request, CancellationToken cancellationToken)
        {
            var productList = await _readUnitOfWork.ProductReadRepository.GetByFilterPagedAsync(request);
            PaginitionResDto<List<ProductResDto>> result = new PaginitionResDto<List<ProductResDto>>
            {
                Data = _mapper.Map<List<ProductResDto>>(productList.Item1),
                TotalCount = productList.Item2,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize
            };

            return result;
        }
    }
