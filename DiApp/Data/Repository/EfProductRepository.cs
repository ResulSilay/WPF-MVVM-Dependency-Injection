using DiApp.Data.Abstract;
using DiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiApp.Data.Repository
{
    public class EfProductRepository : IProductRepository
    {
        public List<ProductEntity> GetAll()
        {
            var listProduct = new List<ProductEntity>()
            {
                new ProductEntity{ ProductId = 7488, Barcode = "S000001", Name = "PRODUCT A", Description = "....", Price = 1000.0, Source = "EntityFramework - MSSQL" },
                new ProductEntity{ ProductId = 7488, Barcode = "S000002", Name = "PRODUCT B", Description = "....", Price = 1000.0, Source = "EntityFramework - MSSQL" },
                new ProductEntity{ ProductId = 7488, Barcode = "S000003", Name = "PRODUCT C", Description = "....", Price = 1000.0, Source = "EntityFramework - MSSQL" },
                new ProductEntity{ ProductId = 7488, Barcode = "S000004", Name = "PRODUCT D", Description = "....", Price = 1000.0, Source = "EntityFramework - MSSQL" }
            };

            return listProduct;
        }
    }
}