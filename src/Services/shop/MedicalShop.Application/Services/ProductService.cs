using MapsterMapper;
using MedicalShop.Contracts.Dtos.Products;
using MedicalShop.Contracts.Repositories;
using MedicalShop.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Application.Services
{
    public class ProductService
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductCategoryDto>> FetchAllProductCategoryAsync()
        {
            var categories = await _productReadRepository.FetchAllProductCategoryAsync();
            return _mapper.Map<List<ProductCategoryDto>>(categories);
        }

        public async Task<ProductCategoryDto> FetchProductCategoryAsync(int id)
        {
            var category = await _productReadRepository.FetchProductCategoryAsync(id);
            return _mapper.Map<ProductCategoryDto>(category);
        }

        public async Task<List<ProductDto>> FetchAllProductEntityAsync()
        {
            var products = await _productReadRepository.FetchAllProductEntityAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<Tuple<List<ProductDto>, int>> GetByFilterPagedAsync(ProductFilterPageReqDto request)
        {
            var (products, totalCount) = await _productReadRepository.GetByFilterPagedAsync( _mapper.Map<ProductFilterPage>(request));

            return new Tuple<List<ProductDto>, int>(_mapper.Map<List<ProductDto>>(products), totalCount);
        }
    }

}
