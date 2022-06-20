using EntityFramework.Data;
using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Logic
{
    public class ShippersLogic : BaseLogic
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Add(Shippers newShippers)
        { 
            context.Shippers.Add(newShippers);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ShipperAEliminar = context.Shippers.Find(id);

            context.Shippers.Remove(ShipperAEliminar);
            context.SaveChanges();
        }

        public void Update(Shippers shippers)
        {
            var shipperUpdate = context.Shippers.Find(shippers.ShipperID);

            shipperUpdate.Phone = shippers.Phone;
            shipperUpdate.CompanyName = shippers.CompanyName;

            context.SaveChanges();
        }
    }
}
