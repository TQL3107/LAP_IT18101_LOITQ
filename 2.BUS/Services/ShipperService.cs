using _1.DAL.Context;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ShipperService : IShipperService
    {
        FpolyDBContext context = new FpolyDBContext();

        public List<Shipper> GetShippers()
        {
            return context.Shippers.ToList();
        }
    }
}
