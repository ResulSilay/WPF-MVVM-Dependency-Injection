using DiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiApp.Business.Service
{
    public interface IProductService
    {
        List<ProductEntity> All();
    }
}
