using EF.LinQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.LinQ.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<Products> ProductosSinStock()
        {
            var query = context.Products
                        .Where(p => p.UnitsInStock < 1);

            return query.ToList();
        }

        public List<Products> ProductosEnStockYCuestanMasDe3PorUnidad()
        {
            var query = context.Products.Where(p => p.UnitsInStock > 0).Where(p => p.UnitPrice > 3);

            return query.ToList();
        }

        public Products ProductoID789ONull()
        {
            var query = from product in context.Products
                        where product.ProductID == 789
                        select product;

            return query.FirstOrDefault();
        }

        public void Add(Products item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products item)
        {
            throw new NotImplementedException();
        }
    }
}
