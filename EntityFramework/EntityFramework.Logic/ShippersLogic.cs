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
    }
}
