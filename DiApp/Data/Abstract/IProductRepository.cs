using DiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiApp.Data.Abstract
{
    public interface IProductRepository
    {
        List<ProductEntity> GetAll();
    }
}
