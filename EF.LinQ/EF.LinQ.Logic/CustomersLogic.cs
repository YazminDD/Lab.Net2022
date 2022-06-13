using EF.LinQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.LinQ.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public List<Customers> ClientesCiudadLondres()
        {
            // var query = context.Customers.Where(c => c.City == "London");

            var query = from customers in context.Customers
                        where customers.City == "London"
                        select customers;

            return query.ToList();
        }

        public List<Customers> ClientesRegionWA()
        {
            var query = context.Customers.Where(c => c.Region == "WA");

            return query.ToList();
        }

        public List<string> NombreClientes()
        {
            var query = from customers in context.Customers
                        select customers.CompanyName;

            return query.ToList();
        }

        public List<Tuple<Customers, Orders>> ClientesRegionWAYOrdenesMayoresA1997()
        {
            var query = from customers in context.Customers
                        join orders in context.Orders on customers.CustomerID equals orders.CustomerID
                        where customers.Region == "WA" && orders.OrderDate > new DateTime(1997, 1, 1)
                        select new {customers, orders };

            return query.AsEnumerable().Select(i => new Tuple<Customers, Orders>(i.customers, i.orders)).ToList();
        }

        public void Add(Customers item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customers item)
        {
            throw new NotImplementedException();
        }

    }
}
