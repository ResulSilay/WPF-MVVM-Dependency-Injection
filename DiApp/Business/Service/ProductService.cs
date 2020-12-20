using DiApp.Data.Abstract;
using DiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiApp.Business.Service
{
    public class ProductService: IProductService
    {

        public readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductEntity> All()
        {
            return _productRepository.GetAll();
        }
    }
}
